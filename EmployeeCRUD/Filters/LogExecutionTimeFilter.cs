using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace EmployeeCRUD.Filters
{
    public class LogExecutionTimeFilter : IAsyncActionFilter
    {
        private readonly ILogger<LogExecutionTimeFilter> logger;
        public LogExecutionTimeFilter(ILogger<LogExecutionTimeFilter> _logger)
        {
            logger = _logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context,ActionExecutionDelegate next)
        {
            var stopwatch = Stopwatch.StartNew();
            var executedContext = await next();
            stopwatch.Stop();

            var actionName = context.ActionDescriptor.DisplayName;
            var elapsedMs = stopwatch.ElapsedMilliseconds;

            logger.LogInformation("loiuudsadaded");

            logger.LogInformation("Action {Action} executed in {ElapsedMilliseconds} ms - filter ra pula", actionName, elapsedMs);
        }

    }
}
