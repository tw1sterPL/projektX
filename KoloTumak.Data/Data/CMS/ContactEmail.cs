using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class ContactEmail
    {

        [Key]
        public int IdPosition { get; set; }

        [Display(Name = "Tytuł email")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NameTextEmail { get; set; }

        [Display(Name = "Email")]
        [Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Email { get; set; }

    }
}
