using DocumentSchool.Aplication.Contract.Service;
using DocumentSchool.Aplication.Services;
using DocumentSchool.Aplication.Repository;
using DocumentSchool.InfraEstructure.Context;
using DocumentSchool.InfraEstructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


var builder = WebApplication.CreateBuilder(args);

var MyConectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DocumentSchoolDbContext>(x =>
{
    x.UseNpgsql(MyConectionString);

});

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDocumentRepository, DocumentRepository>();
builder.Services.AddScoped<IDocumentService, DocumentService>();

builder.Services.AddScoped<IRegistrerRepository, RegistrerRepository>();
builder.Services.AddScoped<IRegistrerService, RegistrerService>();

builder.Services.AddScoped<IRequestRepesitory, RequestRepository>();
builder.Services.AddScoped<IRequestservice, RequestService>();

builder.Services.AddScoped<IStundentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
var app = builder.Build();
app.MapSwagger();
app.UseSwagger();
app.UseSwaggerUI();










app.MapControllers();

app.Run();
