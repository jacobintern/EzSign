using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EzSign.Middleware
{
    public class ActionFilter
    {
        private readonly RequestDelegate _next;

        public ActionFilter(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task Invoke(HttpContext context)
        {
            string content;

            using(var reader = new StreamReader(context.Request.Body))
            {
                content = await reader.ReadToEndAsync();
                context.Request.Body.Seek(0,SeekOrigin.Begin);
            }

            await _next(context);
        }
    }
}