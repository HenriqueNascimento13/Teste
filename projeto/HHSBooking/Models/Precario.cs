using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HHSBooking.Models
{
    public class Precario
    {
        public int IDRegime { get; set; }
        public long IDTipoQuarto { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
