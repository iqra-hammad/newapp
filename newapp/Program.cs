using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using newapp.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("newappContextConnection") ?? throw new InvalidOperationException("Connection string 'newappContextConnection' not found.");

builder.Services.AddDbContext<newappContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<newappUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<newappContext>();

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
app.MapRazorPages();    

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}");

app.Run();
