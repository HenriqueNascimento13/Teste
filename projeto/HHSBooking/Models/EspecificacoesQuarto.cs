using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HHSBooking.Models
{
    public class EspecificacoesQuarto
    {
        public int IDEspecificacao { get; set; }
        public long IDTipoQuarto { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
