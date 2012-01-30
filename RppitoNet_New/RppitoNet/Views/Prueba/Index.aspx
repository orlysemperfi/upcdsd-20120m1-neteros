<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<RppitoNet.Models.RNoticiaBE>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<!--
<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
-->

<table>
    <tr>
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
            Seccion
        </th>
        <th>
            TipoNoticia
        </th>
        <th>
            Fecha
        </th>
        <th>
            Reportero
        </th>
        <th>
            Flg_publicado
        </th>
        <th>
            Flg_twitter
        </th>
        <th>
            Prioridad
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdNoticia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdRecolector) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Titulo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Seccion) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoNoticia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Fecha) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Reportero) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Flg_publicado) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Flg_twitter) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Prioridad) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new {  id=item.IdNoticia  })%> |
            <!--
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
            -->
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
