using System;
using System.Collections.Generic;
using Core.Models;

namespace API.ViewModel
{
    public class AuthorListViewModel
    {
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<DateTime> BirthDate { get; set; }
        public string Name { get; set; }

        public AuthorListViewModel(IEnumerable<Author> authors)
        {
            Authors = authors;
        }
    }
}
