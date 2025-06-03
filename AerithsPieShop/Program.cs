using AerithsPieShop.Models;
using Microsoft.EntityFrameworkCore;

//Create the Web Application Builder
var builder = WebApplication.CreateBuilder(args);

//Register Services for Dependency Injection 
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

//Add MVC Controllers with Views 
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AerithsPieShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AerithsPieShopDbContext")));


// Build the Application 
var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())

{
    app.UseDeveloperExceptionPage();
}
//Set Up Routing 
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
