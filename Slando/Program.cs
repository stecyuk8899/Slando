using Microsoft.EntityFrameworkCore;
using WorkData.DB;

var builder = WebApplication.CreateBuilder(args);
string connStr = builder.Configuration.GetConnectionString("AzureDb");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SlandoDbContext>(x => x.UseSqlServer(connStr));

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
