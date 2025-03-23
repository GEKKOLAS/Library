using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Core.Models
{
    public class Author
    {
        public int Id  { get; set; } 

        [Required(ErrorMessage = "This field is Required")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime BirthDate { get; set; }

    }
}
