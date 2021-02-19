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
                        AuthorFirstName = "Victor",
                        AuthorMiddleName = "",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Fiction = true,
                        Category = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Smin & Schuster",
                        ISBN = "978-0743270755",
                        Fiction = false,
                        Category = "Biography",
                        Price = 14.58,
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorMiddleName = "",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Fiction = false,
                        Category = "Biography",
                        Price = 21.54,
                        Pages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Fiction = false,
                        Category = "Biography",
                        Price = 11.61,
                        Pages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorMiddleName = "",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0743270755",
                        Fiction = false,
                        Category = "Biography",
                        Price = 13.33,
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorMiddleName = "",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Fiction = true,
                        Category = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288

                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorMiddleName = "",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 14.99,
                        Pages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Cal",
                        AuthorMiddleName = "",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Publishing Station",
                        ISBN = "978-1455523023",
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 21.66,
                        Pages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorMiddleName = "",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Fiction = false,
                        Category = "Business",
                        Price = 14.58,
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "",
                        AuthorLastName = "Kearns",
                        Publisher = "Smin & Schuster",
                        ISBN = "978-0743270755",
                        Fiction = true,
                        Category = "Thrillers",
                        Price = 14.58,
                        Pages = 944
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
