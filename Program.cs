using Microsoft.EntityFrameworkCore;
using CAR_RENTAL_SERVICE.Infrastructure;
using CAR_RENTAL_SERVICE.Models;

var builder1 = WebApplication.CreateBuilder(args);

builder1.Services.AddDbContext<CAR_RENTAL_SERVICE.Infrastructure.CarRentalContext>
(
    options=>
        options.UseSqlServer
        (
            connectionString:"server=(local);database=CarRentalServiceDB;integrated security=sspi"
        )
);
  

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
