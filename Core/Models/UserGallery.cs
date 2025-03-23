using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class UserGallery
    {
        public int Id { get; set; }
        public required User User { get; set; }
        public required Book Books { get; set; }

        //[Required(ErrorMessage = "the field {0} is required")]
        //public int Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mn tt}")]
        public DateTime Date { get; set; }

    } 
}
