using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Jazani.Infrastructure.Admins.Persistences;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Infrastructure
builder.Services.AddDbContext<ApplicationDbContext>();

//Domain-Infrastructure

//addSingleton se utiliza cuando la misma instancia se utiliza en todo
//el ciclo de vida del proyecto 
//builder.Services.AddSingleton
//addScoped se recomienda para Sesiones, en REST API es lo mismo que addTransient
////por que son peticiones sin estado,por cada petición se genera una nueva instacia
//y contenedor administrará esa instancia

builder.Services.AddTransient<IOfficeRepository, OfficeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
