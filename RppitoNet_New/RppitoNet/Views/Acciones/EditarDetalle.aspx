<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<RppitoNet.Models.Noticia>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditarDetalle
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EditarDetalle</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Noticia</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdNoticia) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdNoticia) %>
                <%: Html.ValidationMessageFor(model => model.IdNoticia) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Titulo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Titulo) %>
                <%: Html.ValidationMessageFor(model => model.Titulo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Descripcion) %>
                <%: Html.ValidationMessageFor(model => model.Descripcion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Tipo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Tipo) %>
                <%: Html.ValidationMessageFor(model => model.Tipo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Seccion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Seccion) %>
                <%: Html.ValidationMessageFor(model => model.Seccion) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "EditarLista") %>
    </div>

</asp:Content>

