using GeekShop.React.Services;
using GeekShop.React.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);


//Add IoC

builder.Services.AddHttpClient<IProductService, ProductService>();

// Add services to the container.


builder.Services.AddControllersWithViews();

builder.Services.AddSpaStaticFiles(c =>
    c.RootPath = "ClientApp/build"
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapFallbackToFile("index.html"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseSpa(c =>
    c.Options.SourcePath = "ClientApp"
);

app.Run();
