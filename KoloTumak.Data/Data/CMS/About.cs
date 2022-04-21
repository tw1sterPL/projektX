using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class About
    {
        [Key]
        public int IdAbout { get; set; }

        [Display(Name = "Tytuł strony o nas")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Title { get; set; }
        [Display(Name = "Opis   strony o nas")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Description { get; set; }
    }
}
