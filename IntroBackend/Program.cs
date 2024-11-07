using IntroBackend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/breweries", () => new Repository().GetBreweries());

app.Run();
