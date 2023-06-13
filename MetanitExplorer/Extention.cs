namespace MetanitExplorer;

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
        return "new string1";
    }
}