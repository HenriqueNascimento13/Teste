using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class Regimes
    {
        public Regimes()
        {
            Precario = new HashSet<Precario>();
            Reservas = new HashSet<Reservas>();
        }

        public byte Idregime { get; set; }
        public long Idhotel { get; set; }
        public string TipoRegime { get; set; }

        public virtual Hoteis IdhotelNavigation { get; set; }
        public virtual ICollection<Precario> Precario { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}