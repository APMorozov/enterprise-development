using DryCleaner.Application.Services;
using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Interfaces;
using DryCleaner.Infrastructure.InMemory;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IRepository<ProductCategory, int>, ProductCategoryInMemoryRepository>();
builder.Services.AddSingleton<IRepository<Product, int>, ProductInMemoryRepository>();
builder.Services.AddSingleton<IRepository<Client, int>, ClientInMemoryRepository>();
builder.Services.AddSingleton<IRepository<Order, int>, OrderInMemoryRepository>();

builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
