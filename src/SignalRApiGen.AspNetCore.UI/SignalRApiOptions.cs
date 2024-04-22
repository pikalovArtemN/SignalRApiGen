using System;
using System.IO;
using System.Reflection;

namespace SignalRApiGen.AspNetCore.UI;

/// <summary>
///
/// </summary>
public class SignalRApiOptions
{
    /// <summary>
    /// Префикс который будет использован для отрисовка ui для api
    /// </summary>
    public string RoutePrefix { get; set; } = "api";

    /// <summary>
    /// Получить или установить поток для получения index страницы для ui
    /// </summary>
    public Func<Stream> IndexStream { get; set; } = () => typeof(SignalRApiOptions).GetTypeInfo().Assembly
        .GetManifestResourceStream("SignalRApiGen.AspNetCore.UI.index.html")!;

    /// <summary>
    /// Получить или установить заголовок страницы
    /// </summary>
    public string DocumentTitle { get; set; } = "SignalRApi UI";

    /// <summary>
    /// Получить или установить дополнительные заголовки страницы
    /// </summary>
    public string HeadContent { get; set; } = "";
}
