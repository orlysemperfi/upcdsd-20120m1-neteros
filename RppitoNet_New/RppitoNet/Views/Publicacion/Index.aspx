<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<RppitoNet.Models.RNoticiaBE>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Publicación</h2>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

    <table style="width:100%;">
        <tr>
            <td style="width: 57px">
                &nbsp;</td>
            <td style="width: 111px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px">
                Fecha</td>
            <td style="width: 111px">
            <%= Html.TextBox("txtFecha", DateTime.Now.ToString("dd'/'MM'/'yyyy") )%> 
            </td>
            <td>
               
                <input type="submit" value="Consultar" />

            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 57px">
                &nbsp;</td>
            <td style="width: 111px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>

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
            <%: Html.ActionLink("Edit", "Edit", new { id = item.IdNoticia })%>
        </td>
    </tr>
<% } %>

</table>
    <% } %>
</asp:Content>

