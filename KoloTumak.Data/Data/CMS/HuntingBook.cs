using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class HuntingBook
    {
        [Key]
        public int IdHunting { get; set; }

        [Display(Name = "Numer upoważnienia")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string AuthorizationNumber { get; set; }

        [Display(Name = "Miejsce")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string NamePlace { get; set; }

        [Display(Name = "Data rozpoczęcia")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        [DataType(DataType.Date)]
        public DateTime DateHuntingStart { get; set; }

        [Display(Name = "Data zakończenia")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        [DataType(DataType.Date)]
        public DateTime DateHuntingEnd { get; set; }

        public List<HuntersList> Hunter { get; set; }



    }
}
