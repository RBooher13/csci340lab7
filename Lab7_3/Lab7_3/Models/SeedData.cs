using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lab7_3.Data;
using System;
using System.Linq;

namespace Lab7_3.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab7_3Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Lab7_3Context>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Super Smash Bros: Ultimate",
                        ReleaseDate = DateTime.Parse("2018-12-7"),
                        Company = "Nintendo",
                        Console = "Switch",
                        Price = 59.99M
                    },

                    new Game
                    {
                        Title = "The Legend of Zelda: Breath of the Wild",
                        ReleaseDate = DateTime.Parse("2018-3-3"),
                        Company = "Nintendo",
                        Console = "Switch/WiiU",
                        Price = 59.99M
                    },

                    new Game
                    {
                        Title = "Wii Sports: Resort",
                        ReleaseDate = DateTime.Parse("2009-6-25"),
                        Company = "Nintendo",
                        Console = "Wii",
                        Price = 39.99M
                    },

                    new Game
                    {
                        Title = "Cuphead",
                        ReleaseDate = DateTime.Parse("2017-9-29"),
                        Company = "Studio MDHR",
                        Console = "Xbox 1/Switch/PS4",
                        Price = 19.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
