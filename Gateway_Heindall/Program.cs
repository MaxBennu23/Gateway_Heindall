using Gateway_Heindall.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("MySqlConnection") ?? throw new InvalidOperationException("Connection string 'MySqlConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
       Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.2.42-mysql")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();



// Conexao padrao do Identity

/*var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();*/

// Conexao do Mysql via Pomelo

builder.Services.AddDbContext<PrincipalContext>
   (options => options.UseMySql( builder.Configuration.GetConnectionString("MySqlConnection"),
       Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.2.42-mysql")));

builder.Services.AddDbContext<UserConfigContext>
   (options => options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
       Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.2.42-mysql")));

/*builder.Services.AddDbContext<PrincipalContext>
    (options => options.UseMySql(
        "server=185.239.210.205;initial catalog=u839385910_heindall;uid=u839385910_heindall;pwd=Aa@heindall23",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.05.00-MariaDB")));*/

/////////////////////


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
