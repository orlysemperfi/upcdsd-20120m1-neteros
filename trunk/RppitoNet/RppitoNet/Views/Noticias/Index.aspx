<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Noticias
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>EDICION</h2>
    <h2>Noticias</h2>

    <table>
        <tr>
            <th>Seleccionar</th>
            <th>
                IdNoticia
            </th>
            <th>
                IdRecolector
            </th>
            <th>
                Titulo
            </th>
            <th>
                TipoVista
            </th>
            <th>
                Mapa
            </th>
            <th>
                Seccion
            </th>
            <th>
                Fecha
            </th>
            <th>
                Prioridad
            </th>

            <th style="width: 110px">
                Reportero
            </th>            
            <th>
                Estado
            </th>

        </tr>

        <tr>
            <td style="height: 59px">
                <%: Html.ActionLink("Editar", "Editar",  new { /*id=item.IdNoticia*/ }) %> |<asp:CheckBox 
                    runat="server" Checked="True" />
&nbsp;<%: Html.ActionLink("Publicar", "Publicar", new { /*id=item.IdNoticia*/ }) %>|
            </td>
            <td style="height: 59px">
                00100
            </td>
            <td style="height: 59px">
                00001
            </td>
            <td style="height: 59px">
                 García saludó veto a Movadef: “Esa gente ha hecho muchísimo daño al Perú”
            </td>
            <td style="height: 59px">
                Normal
            </td>
            <td style="height: 59px">
                No
            </td>
            <td style="height: 59px">
                Politica
            </td>
            <td style="height: 59px">
                24-01-2012
            </td>
            <td style="height: 59px">
                5
            </td>
             <td style="width: 110px; height: 59px">
                Juan Perez
            </td>
             <td >
                Disponible
            </td>

        </tr>
        </table>
    </form>
</asp:Content>
