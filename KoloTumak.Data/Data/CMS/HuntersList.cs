using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class HuntersList
    {
        [Key]
        public int IdHunters { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(20, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(20, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public string Surname { get; set; }

        [Display(Name = "Selekcjoner/Podstawowy")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(20, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public string Type { get; set; }

        [Display(Name = "Telefon kontaktowy")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        //[MaxLength(22, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public int Contact { get; set; }

        public int IdHunting { get; set; }

        public HuntingBook HuntingBook { get; set; }
    }
}
