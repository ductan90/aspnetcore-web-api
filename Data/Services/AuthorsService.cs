using Microsoft.EntityFrameworkCore.Metadata;
using my_books.Data.Models;
using my_books.Data.ViewModels;
using System.Threading;

namespace my_books.Data.Services
{
    public class AuthorsService
    {
        private readonly AppDbContext _context;
        public AuthorsService(AppDbContext context)// constructor
        {
            _context = context;
        }
        public void AddAuthor(AuthorVM author)
        {
            var _author= new Author()
            {
                FullName = author.FullName,
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
