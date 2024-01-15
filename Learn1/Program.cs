using Learn1.Application.Interfaces;
using Learn1.Application.Services;
using Learn1.Application.Mappers;
using Learn1.Domain.Interfaces;
using Learn1.Persistance;
using Learn1.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// configure connect to db
builder.Services.AddDbContext<Learn1DBContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
        )
);

// Dependency injenction (DI)
//repository:
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// application
builder.Services.AddScoped<IProductService, ProductService>();

// mapper
builder.Services.AddAutoMapper(typeof(MappingProfiles));



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
