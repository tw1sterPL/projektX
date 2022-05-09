using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class EditWWW
    {

        [Key]

        //[Display(Name = "Numer pozycji")]
        public int IdPosition { get; set; }

        [Display(Name = "Nazwa odnośnika")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameNavSite { get; set; }

        [Display(Name = "Nazwa strony")]
        //[Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameSite { get; set; }
    }
}
