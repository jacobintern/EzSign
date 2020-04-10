using Microsoft.AspNetCore.Builder;

namespace EzSign.Middleware{
    public static class CustomMiddleware{
        public static IApplicationBuilder UseActionFilter(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ActionFilter>();
        }
    }
}