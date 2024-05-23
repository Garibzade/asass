using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpacDYNa.DAL;
using SpacDYNa.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DYNaContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddIdentity<AppUser, IdentityRole>(
).AddEntityFrameworkStores<DYNaContext>().AddDefaultTokenProviders();


var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("areas", "{area:exists}/{controller=Card}/{action=Index}/{id?}");
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
