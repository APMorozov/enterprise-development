using Scalar.AspNetCore;

using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Application.Services;
using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Interfaces;
using DryCleaner.Infrastructure.EfCore.Repositories;
using DryCleaner.Infrastructure.EFCore;
using DryCleaner.ServiceDefaults;


var builder = WebApplication.CreateBuilder(args);

builder.AddNpgsqlDbContext<DryCleanerDbContext>("Postgres");

builder.Services.AddScoped<IRepository<ProductCategory, int>, ProductCategoryEfCoreRepository>();
builder.Services.AddScoped<IRepository<Product, int>, ProductEfCoreRepository>();
builder.Services.AddScoped<IRepository<Client, int>, ClientEfCoreRepository>();
builder.Services.AddScoped<IRepository<Order, int>, OrderEfCoreRepository>();

builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAnalyticService, AnalyticService>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.MapDefaultEndpoints();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
