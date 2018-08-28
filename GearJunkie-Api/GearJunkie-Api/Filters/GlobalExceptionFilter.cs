using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GearJunkie.Api.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // todo log this

            context.Result = new ObjectResult(new
            {
                Message = context.Exception.Message
            });

            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        
        }
    }
}
