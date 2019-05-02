using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class TipoQuarto
    {
        public TipoQuarto()
        {
            EspecificacoesQuarto = new HashSet<EspecificacoesQuarto>();
            Precario = new HashSet<Precario>();
            Reservas = new HashSet<Reservas>();
        }

        public long IdtipoQuarto { get; set; }
        public long Idhotel { get; set; }
        public byte Capacidade { get; set; }
        public int Inventario { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public virtual Hoteis IdhotelNavigation { get; set; }
        public virtual ICollection<EspecificacoesQuarto> EspecificacoesQuarto { get; set; }
        public virtual ICollection<Precario> Precario { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}