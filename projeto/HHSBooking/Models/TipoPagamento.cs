using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class TipoPagamento
    {
        public TipoPagamento()
        {
            Pagamento = new HashSet<Pagamento>();
        }

        public short IdtipoPagamento { get; set; }
        public string Designacao { get; set; }

        public virtual ICollection<Pagamento> Pagamento { get; set; }
    }
}