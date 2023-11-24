using System.Configuration;
using CRUD_MVC_AVALICAO.Data;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//builder.Services.AddDbContext<Contexto>
//    (options => options.UseMySql(
//        "server=localhost;initial catalog=CRUD_MVC_AVALIACAO;uid=root;pwd=root",
//        Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.39-mysql")));


builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("IdentityConnection")!);

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

