using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class FooterWWW
    {
        [Key]
        public int IdPosition { get; set; }

        [Display(Name = "Tytuł adsresu")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameFooter { get; set; }

    }
}
