using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class HeaderSiteName
    {
        [Key]
        public int IdSiteHeader { get; set; }

        [Display(Name = "Nazwa koła na stronie głównej")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameSiteHeader { get; set; }
    }
}
