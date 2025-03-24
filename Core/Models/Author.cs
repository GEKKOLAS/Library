using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Author
    {
        [Key]
        public int AuthorID  { get; set; } 

        [Required(ErrorMessage = "This field is Required")]
        public string Name { get; set; }

         public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
