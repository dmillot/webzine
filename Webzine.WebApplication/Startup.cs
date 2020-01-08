namespace Webzine.WebApplication
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Webzine.Repository.Contracts;
    using Webzine.Repository.Local;

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<IStyleRepository , LocalStyleRepository>();
            services.AddScoped<ITitreRepository , LocalTitreRepository>();
            services.AddScoped<IArtisteRepository , LocalArtisteRepository>();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // permet d'accéder au données contenu dans le fichier "wwwroot"
            app.UseStaticFiles();

            app.UseRouting();

            

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "titre-style",
                    pattern: "titre/style/{libelle}",
                    defaults: new { controller = "Style", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "titre",
                    pattern: "titre/{id}",
                    defaults: new { controller = "Titre", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "commenter",
                    pattern: "titre/commenter",
                    defaults: new { controller = "Titre", action = "Commenter" });

                endpoints.MapControllerRoute(
                    name: "artiste",
                    pattern: "artiste/{libelle}",
                    defaults: new { controller = "Artiste", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "home",
                    pattern: "page/{id}",
                    defaults: new { controller = "Home", action = "Index"});

                endpoints.MapControllerRoute(
                    name: "administration-commentaires",
                    pattern: "administration/commentaires",
                    defaults: new { area = "Administration", controller = "Commentaire", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "administration-styles",
                    pattern: "administration/styles",
                    defaults: new { area = "Administration", controller = "Style", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "administration-titres",
                    pattern: "administration/titres",
                    defaults: new { area = "Administration", controller = "Titre", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "administration-artistes",
                    pattern: "administration/artistes",
                    defaults: new { area = "Administration", controller = "Artiste", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "administration",
                    pattern: "{area:exists}/{controller=artiste}/{action=index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}");

            });
        }
    }
}
