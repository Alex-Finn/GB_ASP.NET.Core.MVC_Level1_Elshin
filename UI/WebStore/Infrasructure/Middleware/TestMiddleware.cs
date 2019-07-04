using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Infrasructure.Middleware
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _NextAction;

        public TestMiddleware(RequestDelegate NextAction)
        {
            _NextAction = NextAction;
        }

        public async Task Invoke(HttpContext context)
        {
            await _NextAction(context);
        }
    }
}
