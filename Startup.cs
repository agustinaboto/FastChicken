using FastChicken.Data;
using Microsoft.EntityFrameworkCore;

namespace FastChicken
{
    public static class Startup
    {
        public static WebApplication InicializarApp(string[] args)
        {
            //Crear nueva instancia de nuestro servidor w
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);

            var app = builder.Build();
            Configure(app);

            return app;
        }
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            //builder.Services.AddDbContext<FastChickenContext>(options => options.UseInMemoryDatabase("FastChickenDb"));
            builder.Services.AddDbContext<FastChickenContext>(options => options.UseSqlServer("server=DESKTOP-T0M4S\\SQLEXPRESS; database=FastChicken; Trusted_Connection=true"));
            

            // Add services to the container.
            builder.Services.AddControllersWithViews();
        }

        private static void Configure(WebApplication app)
        {
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
        }
    }
}
