using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace EmployeeCRUD.Filters
{
    public class ApiExceptionFilter : IAsyncExceptionFilter
    {
        public Task OnExceptionAsync(ExceptionContext context)
        {
           
        //var exception = context.Exception;
        //int statusCode = 500; // default

        //if (exception is ArgumentException)
        //        statusCode = 400;
        //    else if (exception is KeyNotFoundException)
        //        statusCode = 404;
        //    else if (exception is UnauthorizedAccessException)
        //        statusCode = 403;

        //    context.Result = new ObjectResult(new
        //    {
        //        status = statusCode,
        //        message = exception.Message
        //    })
        //    {
        //        StatusCode = statusCode
        //    };

            // Return a completed Task because this is async
            return Task.CompletedTask;
        }
    }
}
