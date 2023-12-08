using Microsoft.AspNetCore.Mvc.Diagnostics;
using WebApplicationMVC1.Context;
using WebApplicationMVC1.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // programa vai usar views

builder.Services.AddScoped<InformixContext>();

builder.Services.AddTransient<CidadeRepository>();

builder.Services.AddTransient<EstadoRepository>();

builder.Services.AddTransient<PaisRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    ;
});

app.Run();