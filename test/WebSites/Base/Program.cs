using SignalRApiGen.AspNetCore.UI;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseSignalRApiUI();

app.Run();
