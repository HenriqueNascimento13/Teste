using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class Hoteis
    {
        public Hoteis()
        {
            Regimes = new HashSet<Regimes>();
            Reservas = new HashSet<Reservas>();
            ServicosHotel = new HashSet<ServicosHotel>();
            TipoQuarto = new HashSet<TipoQuarto>();
        }

        public long Idhotel { get; set; }
        public string NomeHotel { get; set; }
        public string NumEstrelas { get; set; }
        public string Morada { get; set; }
        public string Localidade { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
        public short QuantidadeQuartos { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Regimes> Regimes { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
        public virtual ICollection<ServicosHotel> ServicosHotel { get; set; }
        public virtual ICollection<TipoQuarto> TipoQuarto { get; set; }
    }
}