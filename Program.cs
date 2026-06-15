using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using TF_NET_2026_IAC_Bend.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MyDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("Main"));
});

var app = builder.Build();


app.MapOpenApi();

app.MapScalarApiReference();

app.UseAuthorization();

app.MapControllers();

app.Run();
