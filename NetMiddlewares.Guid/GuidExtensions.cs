using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework.Uuid
{
    public static class GuidExtensions
    {
        public static IServiceCollection AddGuid(this IServiceCollection services)
        {
            services.TryAddSingleton<GuidMiddleware, GuidMiddleware>();

            return services;
        }

        public static IApplicationBuilder UseGuid(this IApplicationBuilder app)
        {
            return app.UseMiddleware<GuidMiddleware>();
        }
    }
}
