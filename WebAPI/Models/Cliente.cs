using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cuit_DNI { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }

        public int IDTipoCliente { get; set; }

        public string Observacion { get; set; }

        public string Direccion { get; set; }

        public bool Borrado { get; set; }

    }
}
