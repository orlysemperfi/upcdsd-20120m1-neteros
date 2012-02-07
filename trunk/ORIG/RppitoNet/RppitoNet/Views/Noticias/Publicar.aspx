<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Publicar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Publicar</h2>


     <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <p>¿Estás seguro que desea Publicar la Noticia : <strong>García saludó veto a Movadef: “Esa gente ha hecho muchísimo daño al Perú”</strong></p>
        <fieldset>
            <legend>Publicar Noticia 0001</legend>
            <p>
                <input type="submit" value="Publicar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</asp:Content>
