<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<RppitoNet.Models.NoticiaBE>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edición
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
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Contenido) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.Contenido, new { cols=100, rows=5 }) %>
                <%: Html.ValidationMessageFor(model => model.Contenido) %>
            </div>
            
<%--             RLG 15-02-12
            <div class="editor-label">
                <%: Html.LabelFor(model => model.TipoVista) %>
            </div>
--%>         
<%-- 
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.TipoVista) %>
                <%: Html.ValidationMessageFor(model => model.TipoVista) %>
            </div>
--%>            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Idseccion) %>
            </div>
            <div class="editor-field">
<%--                <%: Html.TextBoxFor(model => model.Idseccion) %>
                <%: Html.ValidationMessageFor(model => model.Idseccion) %>--%>
                <%: @Html.DropDownList("Idseccion", new SelectList((System.Collections.IEnumerable)ViewData["Secciones"], "IdSeccion", "Nombre", Model.Idseccion))%>
            </div>
            
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Fecha) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Fecha, String.Format("{0:g}", Model.Fecha)) %>
                <%: Html.ValidationMessageFor(model => model.Fecha) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Idreportero) %>
            </div>
            <div class="editor-field">
<%--                <%: Html.TextBoxFor(model => model.Idreportero) %>
                <%: Html.ValidationMessageFor(model => model.Idreportero) %>
--%>                
                <%: @Html.DropDownList("Idreportero", new SelectList((System.Collections.IEnumerable)ViewData["Reporteros"], "IdReportero", "Nombre", Model.Idreportero))%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Idvideo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Idvideo) %>
                <%: Html.ValidationMessageFor(model => model.Idvideo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Idimagen) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Idimagen) %>
                <%: Html.ValidationMessageFor(model => model.Idimagen) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.flg_req_mapa) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.flg_req_mapa)%>
                <%: Html.ValidationMessageFor(model => model.flg_req_mapa) %>
            </div>


<%--     rlg
            <div class="editor-label">
                <%: Html.LabelFor(model => model.flg_mapa) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.flg_mapa)%>
                <%: Html.ValidationMessageFor(model => model.flg_mapa) %>
            </div>
--%>            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.flg_publicado) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.flg_publicado, new { @disabled = "true"})%>
                <%: Html.ValidationMessageFor(model => model.flg_publicado) %>
            </div>


            <div class="editor-label">
                <%: Html.LabelFor(model => model.flg_twitter) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.flg_twitter)%>
                <%: Html.ValidationMessageFor(model => model.flg_twitter) %>
            </div>


            <div class="editor-label">
                <%: Html.LabelFor(model => model.prioridad) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.prioridad) %>
                <%: Html.ValidationMessageFor(model => model.prioridad) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</asp:Content>
