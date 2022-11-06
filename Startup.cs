using System.Net;
using BaldursGateAPI.Helpers;
using BaldursGateAPI.Services.Alignment;
using BaldursGateAPI.Services.Character;
using BaldursGateAPI.Services.Class;
using BaldursGateAPI.Services.Race;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");

// Add dependency injection containers
builder.Services.AddScoped<IAlignmentService, AlignmentService>();
builder.Services.AddScoped<IRaceService, RaceService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();

builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddHttpsRedirection(options =>
    {
        options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
        options.HttpsPort = 443;
    });
}
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true); 

builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

app.UseSwagger(); 
app.UseSwaggerUI();

app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();

