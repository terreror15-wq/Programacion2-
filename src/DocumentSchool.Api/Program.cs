using DocumentSchool.Domain.Interfaces;
using DocumentSchool.InfraEstructure.Context;
using DocumentSchool.InfraEstructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var MyConectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DocumentSchoolDbContext>(x =>
{
    x.UseNpgsql(MyConectionString);

});

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStundentRepository, StudentRepository>();
builder.Services.AddScoped<IDocumentRepository, DocumentRepository>();
builder.Services.AddScoped<IRequestRepesitory, RequestRepository>();
builder.Services.AddScoped<IRegistrerRepository, RegistrerRepository>();

var app = builder.Build();
app.MapSwagger();
app.UseSwagger();
app.UseSwaggerUI();










app.MapControllers();

app.Run();
