using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class Management
    {
        [Key]
        public int IdManagement { get; set; }

        [Display(Name = "Tytuł strony zarząd")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Title { get; set; }

        [Display(Name = "Pełnione stanowisko")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Position { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Surname { get; set; }

        
    }
}
