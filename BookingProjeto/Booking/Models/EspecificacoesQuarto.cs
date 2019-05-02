using System;
using System.Collections.Generic;

namespace Booking
{
    public partial class EspecificacoesQuarto
    {
        public short Idespecificacao { get; set; }
        public long IdtipoQuarto { get; set; }
        public string Descricao { get; set; }

        public virtual TipoQuarto IdtipoQuartoNavigation { get; set; }
    }
}