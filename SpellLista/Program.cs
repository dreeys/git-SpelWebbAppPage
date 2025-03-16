using Microsoft.EntityFrameworkCore;
using SpellLista.Models;

var builder = WebApplication.CreateBuilder(args);

// Lägg till DbContext med SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Konfigurera HTTP request pipeline
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Spel}/{action=Index}/{id?}");

app.Run();
