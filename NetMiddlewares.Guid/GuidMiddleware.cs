using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Uuid
{
    public class GuidMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var guid = System.Guid.NewGuid();
            
            context.Request.Headers.Add("X-Guid", guid.ToString());

            context.Response.OnStarting(() =>
            {
                context.Response.Headers.Add("X-Guid", guid.ToString());

                return Task.CompletedTask;
            });

            await next(context);
        }
    }
}
