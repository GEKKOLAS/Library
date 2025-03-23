using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="the field 0 is required")]
        public required string Title { get; set; }

        // Propiedad de navegación
        public required Author Author { get; set; }

        public string? URLImagen { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select an author")]
        public required int AuthorId { get; set; } // Llave foránea
        

    }

}
