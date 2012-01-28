<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Noticias Pendientes de Edición
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EDICION</h2>

    <h2>Noticias de Recolector</h2>

    <table>
        <tr>
            <th></th>
            <th>
                IdRecolector
            </th>
            <th>
                Titulo
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
            <th>
                Reportero
            </th>
        </tr>

        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Editar",  new { /*id=item.IdNoticia*/ }) %> |
            </td>
            <td>
                00001
            </td>
            <td>
                 García saludó veto a Movadef: “Esa gente ha hecho muchísimo daño al Perú”
            </td>
            <td>
                Politica
            </td>
            <td>
                24-01-2012
            </td>
            <td>
                5
            </td>
             <td>
                Juan Perez
            </td>
        </tr>
        </table>
</asp:Content>
