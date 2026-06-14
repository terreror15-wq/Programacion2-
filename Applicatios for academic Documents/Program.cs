using Microsoft.EntityFrameworkCore;
using Tarea_1.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSwaggerGen();
var MyConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationForAcedemicDocuments>(x =>
{
    x.UseSqlServer(MyConnectionString);
});

var app = builder.Build();
app.MapControllers();
app.MapSwagger();
app.UseSwagger();
app.UseSwaggerUI();






app.Run();
