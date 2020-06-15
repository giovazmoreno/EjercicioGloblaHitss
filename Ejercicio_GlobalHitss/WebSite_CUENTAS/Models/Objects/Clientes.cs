using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_CUENTAS.Models.Objects
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string CuentaBancaria { get; set; }
    }
}