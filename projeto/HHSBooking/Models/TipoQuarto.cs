using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HHSBooking.Models
{
    public class TipoQuarto
    {
        public long IDTipoQaurto { get; set; }
        public long IDHotel { get; set; }

        [Required]
        public int Capacidade { get; set; }

        [Required]
        public int Inventario { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
