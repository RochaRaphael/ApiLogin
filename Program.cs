using ApiLogin.Data;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApiLoginDataContext>();

var app = builder.Build();
app.MapControllers();

app.Run();
