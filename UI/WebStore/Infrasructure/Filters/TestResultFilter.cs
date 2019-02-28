using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore.Infrasructure.Filters
{
    public class TestResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
          
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
          
        }
    }
}
