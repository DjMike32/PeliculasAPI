using PeliculasAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
