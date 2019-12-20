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

            // permet d'acc�der au donn�es contenu dans le fichier "wwwroot"
            app.UseStaticFiles();

            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areasParam",
                  pattern: "{area}/{controller=Home}/{action=Index}/{id}"            
                );

                endpoints.MapControllerRoute(
                  name: "adminArtist",
                  pattern: "administration/artiste/edit/{id}",
                  defaults: new { area = "Administration", controller = "AdminArtist", action = "Edit" }
                  );

                endpoints.MapControllerRoute(
                  name: "adminArtist",
                  pattern: "administration/artiste/delete/{id}",
                  defaults: new { area = "Administration", controller = "AdminArtist", action = "Delete" }
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
                  name: "adminArtist",
                  pattern: "administration/artiste/create",
                  defaults: new { area = "Administration", controller = "AdminArtist", action = "Create" }
                  );

                endpoints.MapControllerRoute(
                  name: "adminArtist",               
                  pattern: "administration/artistes",
                  defaults : new {area = "Administration", controller = "AdminArtist", action = "Index" }
                  );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}"
                    );

            });
        }
    }
}
