using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Infrasructure.Middleware
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseTestMiddleware(
            this IApplicationBuilder app, params object[] parameters)
        {
            if (app is null)
                throw new ArgumentNullException(nameof(app));
            app.UseMiddleware<TestMiddleware>();
            return app;
        }
    }
}
