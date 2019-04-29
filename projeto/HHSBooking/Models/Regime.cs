using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HHSBooking.Models
{
    public class Regime
    {
        public int IDRegime { get; set; }

        public long IDHotel { get; set; }

        [Required]
        [Display(Name = "Tipo do Regime")]
        public string TipoRegime { get; set; }
    }
}
