var builder = WebApplication.CreateBuilder(args);

//for endpoint register carter library
builder.Services.AddCarter();
// register mediatr library for the logical CQRS
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});
var app = builder.Build();

app.MapCarter();

app.Run();
