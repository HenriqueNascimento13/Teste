using System;
using System.Collections.Generic;

namespace HHSBooking
{
    public partial class Clientes
    {
        public Clientes()
        {
            Reservas = new HashSet<Reservas>();
        }

        public long Idcliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public string Localidade { get; set; }
        public string CodPostal { get; set; }
        public string Cc { get; set; }
        public string DataNasc { get; set; }
        public string Imagem { get; set; }

        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}