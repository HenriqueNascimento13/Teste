using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class Precario
    {
        public byte Idregime { get; set; }
        public long IdtipoQuarto { get; set; }
        public DateTime Data { get; set; }
        public decimal Preco { get; set; }

        public virtual Regimes IdregimeNavigation { get; set; }
        public virtual TipoQuarto IdtipoQuartoNavigation { get; set; }
    }
}