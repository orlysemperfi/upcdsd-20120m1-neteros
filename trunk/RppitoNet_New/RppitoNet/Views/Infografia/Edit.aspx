<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<RppitoNet.Models.NoticiaBE>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Infografía
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdNoticia) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdNoticia, new { @readonly = "readonly" }) %>
                <%: Html.ValidationMessageFor(model => model.IdNoticia) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdRecolector) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdRecolector) %>
                <%: Html.ValidationMessageFor(model => model.IdRecolector) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Titulo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Titulo) %>
                <%: Html.ValidationMessageFor(model => model.Titulo) %>
            </div>
            
            
            <p>
                <input type="submit" value="Grabar" />
            </p>

            <p>
                <input type="submit" value="Cerrar Infografia" />
            </p>

        </fieldset>
    <% } %>
    <p>
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
</asp:Content>

