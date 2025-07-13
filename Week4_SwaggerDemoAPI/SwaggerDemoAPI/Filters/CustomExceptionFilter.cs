using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SwaggerDemoAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var logPath = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");
            File.AppendAllText(logPath, $"{DateTime.Now}: {context.Exception.Message}\n");

            context.Result = new ObjectResult("Internal server error occurred")
            {
                StatusCode = 500
            };
        }
    }
}
