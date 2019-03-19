using log4net;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Services.MiddleWare
{
    public class ErrorHandlingMiddleWare
    {
        private readonly RequestDelegate _next;
        private static readonly log4net.ILog _log = 
            LogManager.GetLogger(typeof(ErrorHandlingMiddleWare));

        public ErrorHandlingMiddleWare(RequestDelegate Next)
        {
            _next = Next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                await HandleExceptionAsync(context, error);
                throw;
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception error)
        {
            _log.Error(error.Message, error);
            return Task.CompletedTask;
        }
    }
}
