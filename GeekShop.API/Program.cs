using GeekShop.API.Context;
using GeekShop.ProductAPI.Repository;
using GeekShopping.API.Config;
using GeekShopping.ProductAPI.Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//Add IoC
builder.Services.AddScoped<IProductRepository, ProductRepository>();

//Add AutoMapper

builder.Services.AddAutoMapper(typeof(ProductProfile));

//Add DbConnection

var connectionString = builder.Configuration.GetConnectionString("AppDb");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
