// create builder for web application
// load configuration, default service, environment
// return instance web application builder
var builder = WebApplication.CreateBuilder(args);

// build web application
// can config middleware, route
// return instance of web application
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// start server
app.Run();
