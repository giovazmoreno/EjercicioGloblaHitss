using System;
using System.Web.UI;
using System.Net.Http;
using Newtonsoft.Json;
using WebSite_CUENTAS.Models.Objects;
using WebSite_CUENTAS.Models.Response;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var httpClient = new HttpClient();
        var json = httpClient.GetStringAsync("Service1.svc/InfoClientes");
        ListaClientesResponse listaClientes = JsonConverter.DeserializeObject<ListaClientesResponse>(json);

        grdClientes.DataSource = ListaClientesResponse;
        grdClientes.DataBind();
    }

    
    protected void grdClientes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string option = e.CommandName.ToString();
        string Clave = e.CommandArgument.ToString();

        switch (option)
        {
            case "Editar":
                var httpClient = new HttpClient();
                var json = httpClient.GetStringAsync("Service1.svc/InfoCuentasClientes/" + Clave);
                ListaCuentasClienteResponse listaClientes = JsonConverter.DeserializeObject<ListaCuentasClienteResponse>(json);

                grdCuentas.DataSource = ListaCuentasClienteResponse;
                grdCuentas.DataBind();
                break;

           
        }
    }

    
}