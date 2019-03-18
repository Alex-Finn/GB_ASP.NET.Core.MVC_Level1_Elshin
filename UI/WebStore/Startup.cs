using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WebStore.Implementations;
using WebStore.DAL.Context;
using Microsoft.EntityFrameworkCore;
using WebStore.DomainEntities.Entities;
using Microsoft.AspNetCore.Identity;
using WebStore.Interfaces.Api;
using WebStore.Clients.Values;
using WebStore.Interfaces.Services;
using WebStore.Clients.Employees;
using WebStore.Clients.Products;
using WebStore.Clients.Orders;
using Microsoft.Extensions.Logging;
using WebStore.Logger;
using WebStore.Services.MiddleWare;
using WebStore.Services;

namespace WebStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                //options.Filters.Add(typeof(TestResultFilter));
            });

            services.AddTransient<IValueService, ValuesClient>();
            services.AddTransient<IEmployesData, EmployeesClient>();
            //services.AddScoped<IEmployesData, InMemoryEmployesData>();
            //services.AddScoped<IProductData, InMemoryProductData>();
            services.AddScoped<IProductData, ProductsClient>();
			//services.AddScoped<IProductData, SqlProductData>();
			services.AddScoped<ICartStore, CookiesCartStore>();
			services.AddScoped<ICartService, CartService>();
			//services.AddScoped<IOrderService, SqlOrderService>();
			services.AddScoped<IOrderService, OrdersClient>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<WebStoreContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 3;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;

                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                opt.Lockout.MaxFailedAccessAttempts = 10;
                opt.Lockout.AllowedForNewUsers = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(120);


                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";

                options.SlidingExpiration = true;
            });

            services.AddDbContext<WebStoreContext>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("ToFileConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory log)
        {
            log.AddLog4Net();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.UseMiddleware<TestMiddleware>();
            //app.UseTestMiddleware();

            app.MapWhen(context => context.Request.Query.ContainsKey("testparam") &&
                                   context.Request.Query["testparam"] == "1234", action =>
                                   {
                                       action.Run(async context => await context.Response.WriteAsync("Test parameter is 1234"));
                                   });

            app.Map("/Testdata", action =>
            {
                action.Run(async context => await context.Response.WriteAsync("Test Data route"));
            });

            app.UseAuthentication();

            app.UseStatusCodePagesWithRedirects("~/home/ErrorStatus/{0}");

            app.UseMiddleware(typeof(ErrorHandlingMiddleWare));

            app.UseMvc(route =>
            {
                route.MapRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");                
                route.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("hello");
            //});
        }
    }
}
