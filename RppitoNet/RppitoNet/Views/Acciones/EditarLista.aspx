<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<RppitoNet.Models.Noticia>>" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>Editar Listado</h2>

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
                Descripcion
            </th>
            <th>
                Tipo
            </th>
            <th>
                Seccion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "EditarDetalle", new { id=item.IdNoticia }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%: item.IdNoticia %>
            </td>
            <td>
                <%: item.Titulo %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
            <td>
                <%: item.Tipo %>
            </td>
            <td>
                <%: item.Seccion %>
                o</td>
        </tr>
    
    <% } %>

    </table>

   <%-- <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
--%>
    </form>
</asp:Content>

