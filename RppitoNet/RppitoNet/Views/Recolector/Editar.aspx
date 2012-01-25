<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	NUEVO
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>NUEVA NOTICIA DE RECOLECTOR</h2>

     <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Recolector 0001</legend>
            <div class="editor-label">
                Titulo
            </div>
            <div class="editor-field">
                <input id="" type="text" style="width=100px" />
            </div>
            
            <div class="editor-label">
                Contenido
            </div>
            <div class="editor-field">
                <textarea  rows ="10" cols="100" id=""  ></textarea>
            </div>

            <div class="editor-label">
                Tipo de Vista
            </div>
            <div class="editor-field">
                <select>
                  <option value="N">Normal</option>
                  <option value="A">Album de Fotos</option>
                  <option value="V">Video</option>
                </select> 
            </div>
                
            <div class="editor-label">
                Seccion
            </div>
            <div class="editor-field">
                <select>
                  <option value="0">POLITICA</option>
                  <option value="1">ECONOMIA</option>
                  <option value="2">DEPORTES</option>
                </select> 
                
            </div>
             <div class="editor-label">
                Prioridad
            </div>
            <div class="editor-field">
                <select>
                  <option value="1">1</option>
                  <option value="2">2</option>
                  <option value="3">3</option>
                  <option value="4">4</option>
                  <option value="5">5</option>
                </select> 
                
            </div>
            <p>
                <input type="submit" value="Grabar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>
</asp:Content>
