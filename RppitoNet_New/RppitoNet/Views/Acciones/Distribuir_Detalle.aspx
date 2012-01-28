<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<script runat="server">

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Distribuir_Detalle
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>Distribuir_Detalle</h2>
    <p>
        <table style="width:100%;">
            <tr>
                <td style="width: 85px">
                    Código</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server" MaxLength="10" ReadOnly="True" 
                        Width="62px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    Título</td>
                <td>
                    <asp:TextBox ID="txtTitulo" runat="server" MaxLength="200" Width="412px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    Contenido</td>
                <td>
                    <asp:TextBox ID="txtContenido" runat="server" Height="210px" 
                        TextMode="MultiLine" Width="539px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    Sección</td>
                <td>
                    <asp:DropDownList ID="cboSeccion" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    Tipo</td>
                <td>
                    <asp:DropDownList ID="cboTipo" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    Fecha</td>
                <td>
                    <asp:TextBox ID="txtFecha" runat="server" MaxLength="8" Width="76px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 85px">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnTwitter" runat="server" Text="Distribuir Twitter" />
&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
                        Text="Cancelar" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>

    </form>

</asp:Content>
