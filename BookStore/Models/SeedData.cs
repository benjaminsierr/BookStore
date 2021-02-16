using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookStoreContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookStoreContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = 9780451419439,
                        Fiction = true,
                        Category = "Classic",
                        Price = 9.95
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Smin & Schuster",
                        ISBN = 9780743270755,
                        Fiction = false,
                        Category = "Biography",
                        Price = 14.58
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = 9780553384611,
                        Fiction = false,
                        Category = "Biography",
                        Price = 21.54
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = 9780812981254,
                        Fiction = false,
                        Category = "Biography",
                        Price = 11.61
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 9780743270755,
                        Fiction = false,
                        Category = "Biography",
                        Price = 13.33
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = 9780804171281,
                        Fiction = true,
                        Category = "Historical Fiction",
                        Price = 15.95
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 9781455586691,
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 14.99
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Cal Newport",
                        Publisher = "Grand Publishing Station",
                        ISBN = 978-1455523023,
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 21.66
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = 9781591847984,
                        Fiction = false,
                        Category = "Business",
                        Price = 14.58
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Smin & Schuster",
                        ISBN = 9780743270755,
                        Fiction = true,
                        Category = "Thrillers",
                        Price = 14.58
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
