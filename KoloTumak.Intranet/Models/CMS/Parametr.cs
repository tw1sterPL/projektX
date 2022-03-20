using System.ComponentModel.DataAnnotations;

namespace KoloTumak.Intranet.Models.CMS
{
    public class Parametr
    {
        [Key]
        public int IdParametru { get; set; }
        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(10, ErrorMessage = "Kod powinien zawierać max 10 znaków")]
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public string Wartosc { get; set; }
        public string Opis { get; set; }
    }
}
