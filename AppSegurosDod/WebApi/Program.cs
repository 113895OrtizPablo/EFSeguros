using DataLayer.Context;
using DataLayer.Repository.Implementacion;
using DataLayer.Repository.Interface;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IPolizaRepository, PolizaRepository>();


//Contexto con cadena de conexion

builder.Services.AddDbContext<ContextDb>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SegurosDb"))
    );



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
