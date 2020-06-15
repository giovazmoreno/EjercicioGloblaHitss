<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Lista Clientes</h2>
            <p>
                <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="false" DataKeyNames="IdCliente" OnRowCommand="grdClientes_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="6%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEditar" runat="server"
                                    SkinID="EditGrid"
                                    CommandName="Editar"
                                    CommandArgument='<%# Eval("IdCliente")  %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText='ID CLIENTE' DataField='IdCliente' />
                        <asp:BoundField HeaderText='NOMBRE' DataField='Nombres' />
                        <asp:BoundField HeaderText='DIRECCION' DataField='Direccion' />
                        <asp:BoundField HeaderText='EDAD' DataField='Edad' />
                        <asp:BoundField HeaderText='TELEFONO' DataField='Telefono' />
                        <asp:BoundField HeaderText='SEXO' DataField='Sexo' />
                        <asp:BoundField HeaderText='CUENTA BANCARIA' DataField='CuentaBancaria' />

                    </Columns>
                </asp:GridView>
            </p>
        </div>
    </div>

     <div class="row">
        <div class="col-md-4">
            <h2>Lista Cuentas</h2>
            <p>
                <asp:GridView ID="grdCuentas" runat="server" AutoGenerateColumns="false" DataKeyNames="IdCuenta" >
                    <Columns>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="6%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEditar" runat="server"
                                    SkinID="EditGrid"
                                    CommandName="Editar"
                                    CommandArgument='<%# Eval("IdCuenta")  %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText='NUMERO DE TARJETA' DataField='NumeroTarjeta' />
                        <asp:BoundField HeaderText='FECHA VENCIMIENTO' DataField='FechaVencimiento' />
                        <asp:BoundField HeaderText='LINEA CREDITO' DataField='LineaCredito' />
                        <asp:BoundField HeaderText='SALDO DISPONIBLE' DataField='SaldoDisponible' />
                        <asp:BoundField HeaderText='SALDO POR PAGAR' DataField='SaldoPorPagar' />
                        <asp:BoundField HeaderText='TIPO DE TARJETA' DataField='TipoTarjeta' />
                        <asp:BoundField HeaderText='TIPO DE PRODUCTO' DataField='TipoProducto' />
                        
      
                    </Columns>
                </asp:GridView>
            </p>
        </div>
    </div>

</asp:Content>
