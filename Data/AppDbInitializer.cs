using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using Microsoft.AspNetCore.Builder;
using my_books.Data.Models;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st book title",
                        Description = "",
                        IsRead = true,
                        DateRead= DateTime.Now.AddDays(-10),
                        Rate=4,
                        Genre="Bio",
                        Author="First Author",
                        CoverUrl="https...",
                        DateAdded=DateTime.Now

                    },
                    new Book()
                     {
                        Title = "2st book title",
                        Description = "2nd book description",
                        IsRead = false,             
                       
                        Genre = "Bio",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    });
                    context.SaveChanges();
                 } 
            }    

        }
    }
}
