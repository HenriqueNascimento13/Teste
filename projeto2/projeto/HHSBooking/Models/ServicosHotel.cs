using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class ServicosHotel
    {
        public short Idservicos { get; set; }
        public long Idhotel { get; set; }
        public string Descricao { get; set; }

        public virtual Hoteis IdhotelNavigation { get; set; }
    }
}