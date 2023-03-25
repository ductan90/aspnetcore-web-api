﻿using Microsoft.EntityFrameworkCore.Metadata;
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

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();

            return _author;
        }

    }
}
