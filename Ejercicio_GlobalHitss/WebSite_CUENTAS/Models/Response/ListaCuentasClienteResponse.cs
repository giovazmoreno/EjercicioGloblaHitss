using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite_CUENTAS.Models.Objects;

namespace WebSite_CUENTAS.Models.Response
{
    public class ListaCuentasClienteResponse
    {
        public List<CuentasCliente> Clientes { get; set; }
    }
}