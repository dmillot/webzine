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
                    name: "adminStyles",
                    pattern: "administration/styles",
                    defaults: new { area = "Administration", controller = "AdminStyle", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                   name: "adminStyleEdit",
                   pattern: "administration/style/edit/{Id}",
                   defaults: new { area = "Administration", controller = "AdminStyle", action = "EditStyle" }
                   );

                endpoints.MapControllerRoute(
                   name: "adminStyleDelete",
                   pattern: "administration/style/Delete/{Id}",
                   defaults: new { area = "Administration", controller = "AdminStyle", action = "DeleteStyle" }
                   );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}"
                    );


                endpoints.MapControllerRoute(
                name: "adminTitres",
                pattern: "administration/titres",
                defaults: new {area = "Administration", controller = "Title", action = "Index" }
                );

                endpoints.MapControllerRoute(
                name: "adminCreateTitre",
                pattern: "administration/titre/create",
                defaults: new { area = "Administration", controller = "Title", action = "CreateTitle" }
                );

                endpoints.MapControllerRoute(
                name: "adminEditTitre",
                pattern: "administration/titre/edit/{id}",
                defaults: new { area = "Administration", controller = "Title", action = "EditTitle" }
                );

                endpoints.MapControllerRoute(
                name: "adminDeleteTitre",
                pattern: "administration/titre/delete/{id}",
                defaults: new { area = "Administration", controller = "Title", action = "DeleteTitle" }
                );

                endpoints.MapControllerRoute(
                name: "adminComments",
                pattern: "administration/commentaires",
                defaults: new { area = "Administration", controller = "Comment", action = "Index" }
                );
            });
        }
    }
}
