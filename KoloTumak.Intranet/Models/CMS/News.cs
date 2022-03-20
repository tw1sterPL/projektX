using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoloTumak.Intranet.Models.CMS
{
    public class News
    {
        [Key]
        public int IdNews{ get; set; }

        [Display(Name ="Numer pozycji")]
        public int IdPosition { get; set; }

        [Display(Name = "Data dodania")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        [DataType(DataType.Date)]
        public DateTime? DateStart { get; set; }

        [Display(Name = "Osoba dodająca")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        [MaxLength(20, ErrorMessage = "Pole powinno zawierać max 20 znaków")]
        public string NameSurnameAdd { get; set; }


        [Display(Name = "Treść Aktualności")]
        [Column(TypeName="nvarchar(MAX)")]
        [Required(ErrorMessage = "Pole musi zostać wypełnione")]
        public string Contents { get; set; }
    }
}
