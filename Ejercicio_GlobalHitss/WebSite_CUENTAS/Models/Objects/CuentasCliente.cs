using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_CUENTAS.Models.Objects
{
    public class CuentasCliente
    {
        public int IdCuenta { get; set; }
        public string NumeroTarjeta { get; set; }

        public string CuentaBancaria { get; set; }
        public string FechaVencimiento { get; set; }
        public string TipoTarjeta { get; set; }
        public string TipoProducto { get; set; }

        public string LineaCredito { get; set; }
        public string SaldoDisponible { get; set; }
        public string SaldoPorPagar { get; set; }


    }
}