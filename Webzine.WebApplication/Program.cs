//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.WebApplication
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using System;
    using Webzine.EntitiesContext;
    using Webzine.Entity;

    /// <summary>
    /// The Program class configure, build, and run the application host.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Initialize the host.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDb(host);

            host.Run();
        }

        private static void CreateDb(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<WebzineDbContext>();
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the WebHostBuilder class with pre-configured defaults.
        /// </summary>
        /// <param name="args">Command line args.</param>
        /// <returns>A program initialization abstraction.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
