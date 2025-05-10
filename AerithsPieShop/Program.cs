using AerithsPieShop.Models;

//Create the Web Application Builder
var builder = WebApplication.CreateBuilder(args);

//Register Services for Dependency Injection 
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

//Add MVC Controllers with Views 
builder.Services.AddControllersWithViews();

// Build the Application 
var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())

{
    app.UseDeveloperExceptionPage();
}
//Set Up Routing 
app.MapDefaultControllerRoute();
app.Run();
