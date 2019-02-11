using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WebStore.Infrasructure.Middleware;
using WebStore.Infrasructure.Filters;
using WebStore.Infrasructure.Interfaces;
using WebStore.Infrasructure.Implementations;

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

            services.AddSingleton<IEmployesData, InMemoryEmployesData>();
            services.AddSingleton<IProductData, InMemoryProductData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultRoute",
                    template: "{controller=Home}/{action=Index}/{Id?}");
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("hello");
            //});
        }
    }
}
