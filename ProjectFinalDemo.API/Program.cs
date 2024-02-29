using Microsoft.EntityFrameworkCore;
using ProjectFinalDemo.Application.Services;
using ProjectFinalDemo.Application.Services.Interfaces;
using ProjectFinalDemo.Domain.Repositories;
using ProjectFinalDemo.Infrastructure.Data.Data;
using ProjectFinalDemo.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddScoped(typeof(IProductService), typeof(ProductServices));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));

//Add AutoMapper
//obtiene todos los ensamblados cargados en el dominio de la aplicación actual. 
//Esto significa que AutoMapper buscará en todos estos ensamblados cualquier perfil de mapeo que hayas definido
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
