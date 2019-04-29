using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HHSBooking.Models
{
    public class Hoteis
    {
        [Display(Name = " Id do hotel")]
        public long IDHotel { get; set; }

        [Required]
        [Display(Name = " Nome do Hotel")]
        public string nomeHotel { get; set; }

        [Required]
        [Range(1, 5)]
        [Display(Name = "Nª de Estrelas")]
        public string numEstrelas { get; set; }

        [Required]
        [Display(Name = "Morada")]
        public string Morada { get; set; }

        [Required]
        [Display(Name = "Localidade")]
        public string Localidade { get; set; }

        [Required]
        [Display(Name = "Codigo Postal")]
        public string codPostal { get; set; }

        [Required]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Required]
        [Display(Name = "Quartos")]
        public int quantQuarto { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
