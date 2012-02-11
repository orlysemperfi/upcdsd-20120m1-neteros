<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<RppitoNet.Models.RNoticiaBE>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Infografía</h2>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>


    <table style="width:100%;">
        
        <tr>
            <td style="width: 57px">
                Estado</td>
            <td style="width: 111px">
            <select id= "cboEstado" >
                <option value="0">Pendiente</option>
                <option value="1">Mapeado</option>
            </select>
            
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
            CoordX
        </th>
        <th>
            CoordY
        </th>
        <th>
            Flg_Mapeado
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
            <%: Html.DisplayFor(modelItem => item.) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Flg_twitter) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Prioridad) %>
        </td>
        <td>
            <%: Html.ActionLink("Mapear", "Edit", new { id = item.IdNoticia })%>
        </td>
    </tr>
<% } %>

</table>
    <% } %>

</asp:Content>

