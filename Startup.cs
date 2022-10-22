using BaldursGateAPI.Helpers;
using BaldursGateAPI.Services.Alignment;
using BaldursGateAPI.Services.Character;
using BaldursGateAPI.Services.Class;
using BaldursGateAPI.Services.Classes;
using BaldursGateAPI.Services.Race;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");

// Add dependency injection containers
builder.Services.AddScoped<IAlignmentService, AlignmentService>();
builder.Services.AddScoped<IRaceService, RaceService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true); 

builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();

