using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectSem3.Models;
using Microsoft.AspNetCore.Identity;
using ProjectSem3.Data;
using ProjectSem3.Areas.Identity.Data;
using Microsoft.Identity.Client;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ProjectDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ProjectDbContextConnection' not found.");


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>( options =>
{
    options.Password.RequireUppercase = false;
});

//builder.Services.AddDbContext<AbcCvContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("AbcCvContext")));

builder.Services.AddMvc().AddRazorRuntimeCompilation();

builder.Services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.BottomRight; });

builder.Services.AddDbContext<AbcCvContext>();
builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ProjectDbContext>();

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
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Homes}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
