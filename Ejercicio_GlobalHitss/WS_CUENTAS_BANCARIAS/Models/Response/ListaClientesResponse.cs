using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_CUENTAS_BANCARIAS.Models.Objects;

namespace WS_CUENTAS_BANCARIAS.Models.Response
{
    public class ListaClientesResponse
    {
        public List<Clientes> Clientes { get; set; }
    }
}