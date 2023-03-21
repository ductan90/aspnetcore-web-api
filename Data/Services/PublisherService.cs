using Microsoft.EntityFrameworkCore.Metadata;
using my_books.Data.Models;
using my_books.Data.ViewModels;
using System.Threading;

namespace my_books.Data.Services
{
    public class PublishersService
    {
        private readonly AppDbContext _context;
        public PublishersService(AppDbContext context)// constructor
        {
            _context = context;
        }
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher= new Publisher()
            {
                Name = publisher.Name,
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
