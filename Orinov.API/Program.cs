using Microsoft.EntityFrameworkCore;
using Orinov.Application;
using Orinov.Data.Context;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceConfigurations();
builder.Services.AddDIContainers();
builder.Services.AddDbContext<OrinovDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("LocalDB")));

var app = builder.Build();

app.AddApplicationMiddlewares();