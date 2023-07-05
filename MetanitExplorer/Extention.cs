﻿namespace MetanitExplorer;

// методы расширения предопределенных классов
public static class TokenExtensions
{
    public static IApplicationBuilder UseToken(this IApplicationBuilder builder)
    {
        return builder.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("middleware");
            await next.Invoke();
        });
    }
    
    public new static string ToLower(this string builder)
    {
        Console.WriteLine("2352523534263463456");
    }
}
