using Jazani.Application.Admins.Dtos.Offices.Mappers;
using Jazani.Application.Admins.Services;
using Jazani.Application.Admins.Services.Implementations;
using Jazani.Infrastructure.Cores.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Infrastructure
builder.Services.addInfrastructureServices(builder.Configuration);

//Applications
builder.Services.AddTransient<IOfficeService,OfficeService>();

//AutoMapper
builder.Services.AddAutoMapper(typeof(OfficeMapper));
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
