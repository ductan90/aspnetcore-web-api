using my_books.Data.Models;

namespace my_books.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { set; get; }
    }

    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }   
        public List<BookAuthorVM> BookAuthors { set; get; }
    }

    public class BookAuthorVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }

    }
}
