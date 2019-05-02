using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class Reservas
    {
        public long Idreserva { get; set; }
        public long Idhotel { get; set; }
        public long Idcliente { get; set; }
        public byte Idregime { get; set; }
        public long IdtipoQuarto { get; set; }
        public long CodPagamento { get; set; }
        public short QuantAdultos { get; set; }
        public short QuantCriancas { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public virtual Pagamento CodPagamentoNavigation { get; set; }
        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual Hoteis IdhotelNavigation { get; set; }
        public virtual Regimes IdregimeNavigation { get; set; }
        public virtual TipoQuarto IdtipoQuartoNavigation { get; set; }
    }
}