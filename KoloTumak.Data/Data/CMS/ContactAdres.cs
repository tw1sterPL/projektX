using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class ContactAdres
    {
        [Key]
        public int IdPosition { get; set; }

        [Display(Name = "Tytuł adsresu")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameTextAdres { get; set; }

        [Display(Name = "Adres")]
        [Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Adres { get; set; }

    }
}
