<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>MAPEAR NOTICIAS</h2>

    <h2>Noticias a mapear</h2>

    <table>
        <tr>
            <th></th>
            <th>
                IdNoticia
            </th>
            <th>
                Titulo
            </th>
            <th>
                Mapa
            </th>
            <th>
                Fecha
            </th>
            <th>
                Prioridad
            </th>
        </tr>

        <tr>
            <td>
                <%: Html.ActionLink("Mapear", "Mapear",  new { /*id=item.IdNoticia*/ }) %> |
            </td>
            <td>
                00100
            </td>
            <td>
                 García saludó veto a Movadef: “Esa gente ha hecho muchísimo daño al Perú”
            </td>
            <td>
                Si
            </td>
            <td>
                24-01-2012
            </td>
            <td>
                5
            </td>
        </tr>
        </table>

</asp:Content>
