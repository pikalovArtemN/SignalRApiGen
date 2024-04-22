using Microsoft.AspNetCore.Builder;
namespace SignalRApiGen.AspNetCore.UI;

/// <summary>
///
/// </summary>
public static class UIBuilderExtension
{
    /// <summary>
    /// Register the SignalRApi middleware with provided options
    /// </summary>
    public static IApplicationBuilder UseSignalRApiUI(this IApplicationBuilder app)
    {
        return app.UseMiddleware<SignalRApiMiddleware>();
    }
}

