using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS_CUENTAS_BANCARIAS.Models.Objects;
using WS_CUENTAS_BANCARIAS.Models.Response;

namespace WS_CUENTAS_BANCARIAS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        private string dbConnection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString.ToString();
        //Consulta base de datos para obtener lista de clientes
        public ListaClientesResponse InfoClientes()
        {
            var listaClientes = new ListaClientesResponse();
            var lstCliente = new  List<Clientes>();
            var tablaCliente = new DataTable();

            try
            {
                tablaCliente = obtenerListaClientes();
                if (tablaCliente != null && tablaCliente.Rows.Count > 0)
                {
                    foreach (DataRow item in tablaCliente.Rows)
                    {
                        lstCliente.Add(new Clientes
                        {
                            IdCliente = int.Parse(item["IDCLIENTE"].ToString() ),
                            Nombres = item["NOMBRE"].ToString(),
                            ApellidoPaterno = item["APELLIDO_PATERNO"].ToString(),
                            ApellidoMaterno = item["APELLIDO_MATERNO"].ToString(),
                            Direccion = item["DIRECCION"].ToString(),
                            Edad = item["EDAD"].ToString(),
                            Telefono = item["TELEFONO"].ToString(),
                            Sexo = item["SEXO"].ToString(),
                            CuentaBancaria = item["CUENTA_BANCARIA"].ToString()
                        });
                    }
                }
                    }
            catch (Exception ex)
            {

            }

            return listaClientes;
        }

        public ListaCuentasClienteResponse InfoCuentasClientes(int idcliente)
        {
            var listaCuentasClientes = new ListaCuentasClienteResponse();
            var lstCuentas = new List<CuentasCliente>();
            var tablaCuentas = new DataTable();

            try
            {
                tablaCuentas = obtenerListaCuentasCliente(idcliente);
                if (tablaCuentas != null && tablaCuentas.Rows.Count > 0)
                {
                    foreach (DataRow item in tablaCuentas.Rows)
                    {
                        lstCuentas.Add(new CuentasCliente
                        {
                            IdCuenta = int.Parse(item["ID_CUENTA"].ToString()),
                            NumeroTarjeta = item["NUMERO_TARJETA"].ToString(),
                            FechaVencimiento = item["FECHA_VENCIMIENTO"].ToString(),
                            LineaCredito = item["LINEA_CREDITO"].ToString(),
                            SaldoDisponible = item["SALDO_DISPONIBLE"].ToString(),
                            SaldoPorPagar = item["SALDO_POR_PAGAR"].ToString(),
                            TipoTarjeta = item["TIPO_TARJETA"].ToString(),
                            TipoProducto = item["TIPO_PRODUCTO"].ToString()


                        });
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return listaCuentasClientes;
        }

        private DataTable obtenerListaClientes()
        {
            DataTable dtResultado = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spClientes_Cuentas_Catalog", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("Action", "SELECT_CLIENTES_CUENTAS"));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dtResultado);
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtResultado;

        }

        private DataTable obtenerListaCuentasCliente(int idcliente)
        {
            DataTable dtResultado = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spClientes_Cuentas_Catalog", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("Action", "SELECT_CLIENTES_CUENTAS"));
                    command.Parameters.Add(new SqlParameter("IDCLIENTE", idcliente));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dtResultado);
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtResultado;

        }


    }
}
