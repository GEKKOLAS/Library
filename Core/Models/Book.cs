using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "the field 0 is required")]
        public string Title { get; set; }

        [ForeignKey("AuthorID")]
        public Author? Author { get; set; }

        public string? URLImagen { get; set; }



        [Range(1, int.MaxValue, ErrorMessage = "Select an author")]
        public int AuthorID { get; set; } // Llave foránea




    }

}
