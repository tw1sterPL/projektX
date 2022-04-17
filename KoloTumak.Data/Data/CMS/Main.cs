using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data.CMS
{
    public class Main
    {
        [Key] // Annotations, klucz główny
        public int IdStrony { get; set; }
        [Required(ErrorMessage = "Wpisz tytuł odnośnika")] //pole wymagane
        [MaxLength(10, ErrorMessage = "Tytuł powinien zawierać max 10 znaków")] //maksymalny rozmiar
        [Display(Name = "Tytuł odnośnika")] // wyświetlana nazwa dla użytkownika
        public string LinkName { get; set; } // tytuł strony
        [Required(ErrorMessage = "Wpisz tytuł strony")]
        [MaxLength(15, ErrorMessage = "Tytuł powinien zawierać max 15 znaków")]
        [Display(Name = "Tytuł strony")]
        public string Name { get; set; }
        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]//decydujemy że w bazie danych nvarchcar bedzie max
        public string Contents { get; set; }
        [Display(Name = "Pozycja wyświetlania")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Position { get; set; }
    }
}
