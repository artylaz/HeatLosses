using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

var enCulture = new CultureInfo("en-US");
CultureInfo.CurrentCulture = enCulture;
CultureInfo.CurrentUICulture = enCulture;
CultureInfo.DefaultThreadCurrentCulture = enCulture;
CultureInfo.DefaultThreadCurrentUICulture = enCulture;

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
