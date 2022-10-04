using GeekShop.Web.Services.IServices;
using GeekShop.Web.Services;

var builder = WebApplication.CreateBuilder(args);

//Add IoC

builder.Services.AddHttpClient<IProductService, ProductService>(c =>
                    c.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ProductAPI"]));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=ProductIndex}/{id?}");

app.Run();
