//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.WebApplication
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System.IO;
    using Webzine.EntitiesContext;
    using Webzine.Repository.Contracts;
    using Webzine.Repository.Db;
    using Webzine.Repository.Local;

    /// <summary>
    /// The Startup class configures services and the app's request pipeline.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit <see href="https://go.microsoft.com/fwlink/?LinkID=398940"/>
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            IConfiguration config =  new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            var repository = config["Repository"];

            if(repository == "Local")
            {
                services.AddScoped<IStyleRepository, LocalStyleRepository>();
                services.AddScoped<ITitreRepository, LocalTitreRepository>();
                services.AddScoped<IArtisteRepository, LocalArtisteRepository>();
                services.AddScoped<ICommentaireRepository, LocalCommentaireRepository>();
            }
            else
            {
                services.AddScoped<IStyleRepository, DbStyleRepository>();
                services.AddScoped<ITitreRepository, DbTitreRepository>();
                services.AddScoped<IArtisteRepository, DbArtisteRepository>();
                services.AddScoped<ICommentaireRepository, DbCommentaireRepository>();
                services.AddDbContext<WebzineDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebzineDbContext;Trusted_Connection=True;MultipleActiveResultSets=true")); // Connect to database
            }

           

        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Provides the mechanisms to configure an application's request pipeline.</param>
        /// <param name="env">Provides information about the web hosting environment an application is running in.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enables static file serving for the current request path
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "titre-style",
                    pattern: "titres/style/{libelle}",
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
                    pattern: "artiste/{name}",
                    defaults: new { controller = "Artiste", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "home",
                    pattern: "page/{id}",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "rechercher",
                    pattern: "rechercher",
                    defaults: new { controller = "Research", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "liker",
                    pattern: "titre/liker",
                    defaults: new { controller = "Titre", action = "Liker" });

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
                    pattern: "{controller=home}/{action=index}/{id=0}");
            });
        }
    }
}
