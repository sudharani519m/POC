namespace MVCCodeFirstInCore.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;

    public class LogActionFilter : IActionFilter
    {
        private readonly ILogger<LogActionFilter> _logger;

        public LogActionFilter(ILogger<LogActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Bankinmg -- userid,Ipaddress,Browser,Start time 
            // This method runs before the action method
            _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' is starting.");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //refid,balance,completion time
            // This method runs after the action method
            _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' has completed.");
        }
    }
}
