using Microsoft.EntityFrameworkCore;
using MVCCodeFirstInCore.Filters;
using MVCCodeFirstInCore.Models;
using MVCCodeFirstInCore.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(options =>
{
    options.Filters.Add<LogActionFilter>();
});

builder.Services.AddDbContext<DotnetCoreDBContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbConn")));

builder.Services.AddScoped<IProductService, ProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
