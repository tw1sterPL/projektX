using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class Contact
    {
        [Key]

        [Display(Name = "Numer pozycji")]
        public int IdPosition { get; set; }

        [Display(Name = "Typ Pola")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameText { get; set; }

        [Display(Name = "Opis")]
        [Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Contents { get; set; }
    }
}
