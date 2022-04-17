using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class EventsAllUser
    {
        [Key]
        public int IdEvents { get; set; }

        [Display(Name = "Data rozpoczęcia")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        [DataType(DataType.Date)]
        public DateTime? DateStart { get; set; }

        [Display(Name = "Typ")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(40, ErrorMessage ="Pole powinno zawierać max 20 znaków")]
        public string Type { get; set; }

        [Display(Name = "Miejsce wydarzenia")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(20, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public string Place { get; set; }

        [Display(Name = "Miejsce wydarzenia")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(20, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public string NameSurnameResponsiblePerson { get; set; }

        [Display(Name = "Telefon kontaktowy")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(22, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public int Contact { get; set; }
    }
}
