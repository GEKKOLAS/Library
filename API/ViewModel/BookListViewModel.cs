using System;
using Core.Models;

namespace API.ViewModel;

public class BookListViewModel
{
    public IEnumerable<Book> Books { get; set; }
    public IEnumerable<Author> Authors { get; set; }
    public string Title { get; set; }
    public string? Author { get; set; }

    public BookListViewModel(IEnumerable<Book> books, IEnumerable<Author> authors)
    {
        Books = books;
        Authors = authors;
    }

}
