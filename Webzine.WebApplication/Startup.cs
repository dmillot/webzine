using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Webzine.WebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllersWithViews();
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
                    name: "style",
                    pattern: "titres/style/{style}",
                    defaults: new { controller = "Style", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    name: "recherche",
                    pattern: "recherche",
                    defaults: new { controller = "Search", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                  name: "titre",
                  pattern: "titre/{id:int}",
                  defaults: new { controller = "Titre", action = "Index" }
                  );

                endpoints.MapControllerRoute(
                name: "artiste",
                pattern: "artiste/{name}",
                defaults: new { controller = "Artist", action = "Index" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}"
                    );
            });
        }
    }
}
