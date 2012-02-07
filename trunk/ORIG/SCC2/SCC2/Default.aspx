<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SCC2._Default" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
            font-weight: bold;
        }
        .style2
        {
        }
        .style3
        {
            height: 184px;
        }
        .style4
        {
            height: 184px;
            width: 212px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;</h2>
    <h2>
        AGREGAR NOTICIA</h2>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    <span class="style1">Subir video<br />
                    </span>
                    <asp:FormView ID="FormView5" runat="server" DataKeyNames="Idvideo" 
                        DataSourceID="SQLVideo" DefaultMode="Insert">
                        <EditItemTemplate>
                            Idvideo:
                            <asp:Label ID="IdvideoLabel1" runat="server" Text='<%# Eval("Idvideo") %>' />
                            <br />
                            Link:
                            <asp:TextBox ID="LinkTextBox" runat="server" Text='<%# Bind("Link") %>' />
                            <br />
                            Descripcion:
                            <asp:TextBox ID="DescripcionTextBox" runat="server" 
                                Text='<%# Bind("Descripcion") %>' />
                            <br />
                            Idseccion:
                            <asp:TextBox ID="IdseccionTextBox" runat="server" 
                                Text='<%# Bind("Idseccion") %>' />
                            <br />
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                CommandName="Update" Text="Update" />
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        Ruta:</td>
                                    <td>
                                        <asp:TextBox ID="LinkTextBox" runat="server" Height="19px" 
                                            Text='<%# Bind("Link") %>' Width="319px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Descripcíón</td>
                                    <td>
                                        <asp:TextBox ID="DescripcionTextBox" runat="server" Height="47px" 
                                            Text='<%# Bind("Descripcion") %>' TextMode="MultiLine" Width="315px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Seccion</td>
                                    <td>
                                        <asp:TextBox ID="IdseccionTextBox" runat="server" 
                                            Text='<%# Bind("Idseccion") %>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                            CommandName="Insert" Text="Subir" />
                                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                                            CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                    </td>
                                </tr>
                            </table>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            Idvideo:
                            <asp:Label ID="IdvideoLabel" runat="server" Text='<%# Eval("Idvideo") %>' />
                            <br />
                            Link:
                            <asp:Label ID="LinkLabel" runat="server" Text='<%# Bind("Link") %>' />
                            <br />
                            Descripcion:
                            <asp:Label ID="DescripcionLabel" runat="server" 
                                Text='<%# Bind("Descripcion") %>' />
                            <br />
                            Idseccion:
                            <asp:Label ID="IdseccionLabel" runat="server" Text='<%# Bind("Idseccion") %>' />
                            <br />
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                                CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                                CommandName="Delete" Text="Delete" />
                            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                CommandName="New" Text="New" />
                        </ItemTemplate>
                    </asp:FormView>
                </td>
                <td class="style3">
                    <span class="style1">Subir foto</span><br />
                    <asp:FormView ID="FormView4" runat="server" DataKeyNames="Idimagen" 
                        DataSourceID="SqlFoto" DefaultMode="Insert">
                        <EditItemTemplate>
                            Idimagen:
                            <asp:Label ID="IdimagenLabel1" runat="server" Text='<%# Eval("Idimagen") %>' />
                            <br />
                            Link:
                            <asp:TextBox ID="LinkTextBox" runat="server" Text='<%# Bind("Link") %>' />
                            <br />
                            Descripcion:
                            <asp:TextBox ID="DescripcionTextBox" runat="server" 
                                Text='<%# Bind("Descripcion") %>' />
                            <br />
                            Idseccion:
                            <asp:TextBox ID="IdseccionTextBox" runat="server" 
                                Text='<%# Bind("Idseccion") %>' />
                            <br />
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                CommandName="Update" Text="Update" />
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        Ruta:</td>
                                    <td>
                                        <asp:TextBox ID="LinkTextBox" runat="server" Height="23px" 
                                            Text='<%# Bind("Link") %>' Width="334px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Descripcíón</td>
                                    <td>
                                        <asp:TextBox ID="DescripcionTextBox" runat="server" Height="48px" 
                                            Text='<%# Bind("Descripcion") %>' TextMode="MultiLine" Width="354px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Seccion</td>
                                    <td>
                                        <asp:TextBox ID="IdseccionTextBox" runat="server" 
                                            Text='<%# Bind("Idseccion") %>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        &nbsp;<asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                            CommandName="Insert" Text="Subir" />
                                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                                            CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                    </td>
                                </tr>
                            </table>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            Idimagen:
                            <asp:Label ID="IdimagenLabel" runat="server" Text='<%# Eval("Idimagen") %>' />
                            <br />
                            Link:
                            <asp:Label ID="LinkLabel" runat="server" Text='<%# Bind("Link") %>' />
                            <br />
                            Descripcion:
                            <asp:Label ID="DescripcionLabel" runat="server" 
                                Text='<%# Bind("Descripcion") %>' />
                            <br />
                            Idseccion:
                            <asp:Label ID="IdseccionLabel" runat="server" Text='<%# Bind("Idseccion") %>' />
                            <br />
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                                CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                                CommandName="Delete" Text="Delete" />
                            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                CommandName="New" Text="New" />
                        </ItemTemplate>
                    </asp:FormView>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <span class="style1">Subir borrador</span><br />
                    <asp:FormView ID="FormView3" runat="server" DataKeyNames="IdTexto" 
                        DataSourceID="SqlTexto" DefaultMode="Insert" Width="911px">
                        <EditItemTemplate>
                            IdTexto:
                            <asp:Label ID="IdTextoLabel1" runat="server" Text='<%# Eval("IdTexto") %>' />
                            <br />
                            Titulo:
                            <asp:TextBox ID="TituloTextBox" runat="server" Text='<%# Bind("Titulo") %>' />
                            <br />
                            Contenido:
                            <asp:TextBox ID="ContenidoTextBox" runat="server" 
                                Text='<%# Bind("Contenido") %>' />
                            <br />
                            Idseccion:
                            <asp:TextBox ID="IdseccionTextBox" runat="server" 
                                Text='<%# Bind("Idseccion") %>' />
                            <br />
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                CommandName="Update" Text="Update" />
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        Titulo:</td>
                                    <td>
                                        <asp:TextBox ID="TituloTextBox0" runat="server" Text='<%# Bind("Titulo") %>' 
                                            Width="727px" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        Sección:</td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList2" runat="server">
                                            <asp:ListItem Selected="True" Value="0">Seleccione</asp:ListItem>
                                            <asp:ListItem Value="1">Economía</asp:ListItem>
                                            <asp:ListItem Value="2">Fútbol</asp:ListItem>
                                            <asp:ListItem Value="3">Actualidad</asp:ListItem>
                                            <asp:ListItem Value="4">Ocio</asp:ListItem>
                                            <asp:ListItem Value="5">Gastronomía</asp:ListItem>
                                            <asp:ListItem Value="6">Finanzas</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        Descripcíón</td>
                                    <td>
                                        <asp:TextBox ID="ContenidoTextBox0" runat="server" Height="183px" 
                                            Text='<%# Bind("Contenido") %>' TextMode="MultiLine" Width="781px" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                            CommandName="Insert" Text="Subir" />
                                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                                            CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            IdTexto:
                            <asp:Label ID="IdTextoLabel" runat="server" Text='<%# Eval("IdTexto") %>' />
                            <br />
                            Titulo:
                            <asp:Label ID="TituloLabel" runat="server" Text='<%# Bind("Titulo") %>' />
                            <br />
                            Contenido:
                            <asp:Label ID="ContenidoLabel" runat="server" Text='<%# Bind("Contenido") %>' />
                            <br />
                            Idseccion:
                            <asp:Label ID="IdseccionLabel" runat="server" Text='<%# Bind("Idseccion") %>' />
                            <br />
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                                CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                                CommandName="Delete" Text="Delete" />
                            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                CommandName="New" Text="New" />
                        </ItemTemplate>
                    </asp:FormView>
                </td>
            </tr>
            <tr>
                <td colspan="2">
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="IdRecolector" 
            DataSourceID="SqlRecolector" DefaultMode="Insert" Width="903px">
            <EditItemTemplate>
                IdRecolector:
                <asp:Label ID="IdRecolectorLabel1" runat="server" 
                    Text='<%# Eval("IdRecolector") %>' />
                <br />
                Idtexto:
                <asp:TextBox ID="IdtextoTextBox" runat="server" Text='<%# Bind("Idtexto") %>' />
                <br />
                Idvideo:
                <asp:TextBox ID="IdvideoTextBox" runat="server" Text='<%# Bind("Idvideo") %>' />
                <br />
                Idseccion:
                <asp:TextBox ID="IdseccionTextBox" runat="server" 
                    Text='<%# Bind("Idseccion") %>' />
                <br />
                Fecha:
                <asp:TextBox ID="FechaTextBox" runat="server" Text='<%# Bind("Fecha") %>' />
                <br />
                Prioridad:
                <asp:TextBox ID="PrioridadTextBox" runat="server" 
                    Text='<%# Bind("Prioridad") %>' />
                <br />
                NombreReportero:
                <asp:TextBox ID="NombreReporteroTextBox" runat="server" 
                    Text='<%# Bind("NombreReportero") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Idtexto:
                <asp:TextBox ID="IdtextoTextBox" runat="server" Text='<%# Bind("Idtexto") %>' />
                Idvideo:
                <asp:TextBox ID="IdvideoTextBox" runat="server" Text='<%# Bind("Idvideo") %>' 
                    Height="22px" Width="128px" />
                Idseccion:
                <asp:TextBox ID="IdseccionTextBox" runat="server" 
                    Text='<%# Bind("Idseccion") %>' />
                &nbsp;<asp:Button ID="Button1" runat="server" Height="24px" onclick="Button1_Click" 
                    Text="Cargar" Width="93px" />
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="style2">
                            Prioridad</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                SelectedValue='<%# Bind("Prioridad") %>'>
                                <asp:ListItem Value="1">1 (Baja)</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3 (Normal)</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5 (Alta)</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Reportero</td>
                        <td>
                            <asp:TextBox ID="NombreReporteroTextBox" runat="server" 
                                Text='<%# Bind("NombreReportero") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Fecha:
                        </td>
                        <td>
                            &nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                                BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
                                DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                                ForeColor="#003399" Height="200px" SelectedDate='<%# Bind("Fecha") %>' 
                                Width="220px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                                    Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                CommandName="Insert" Text="Subir" />
                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                                CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                        </td>
                    </tr>
                </table>
                <br />
            </InsertItemTemplate>
            <ItemTemplate>
                IdRecolector:
                <asp:Label ID="IdRecolectorLabel" runat="server" 
                    Text='<%# Eval("IdRecolector") %>' />
                <br />
                Idtexto:
                <asp:Label ID="IdtextoLabel" runat="server" Text='<%# Bind("Idtexto") %>' />
                <br />
                Idvideo:
                <asp:Label ID="IdvideoLabel" runat="server" Text='<%# Bind("Idvideo") %>' />
                <br />
                Idseccion:
                <asp:Label ID="IdseccionLabel" runat="server" Text='<%# Bind("Idseccion") %>' />
                <br />
                Fecha:
                <asp:Label ID="FechaLabel" runat="server" Text='<%# Bind("Fecha") %>' />
                <br />
                Prioridad:
                <asp:Label ID="PrioridadLabel" runat="server" Text='<%# Bind("Prioridad") %>' />
                <br />
                NombreReportero:
                <asp:Label ID="NombreReporteroLabel" runat="server" 
                    Text='<%# Bind("NombreReportero") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                    CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                    CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                    CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
                </td>
            </tr>
        </table>
    </p>
    <asp:SqlDataSource ID="SqlTexto" runat="server" 
        ConnectionString="<%$ ConnectionStrings:Rpp_DbConn %>" 
        DeleteCommand="DELETE FROM [NodoTexto] WHERE [IdTexto] = @IdTexto" 
        InsertCommand="INSERT INTO [NodoTexto] ([Titulo], [Contenido], [Idseccion]) VALUES (@Titulo, @Contenido, @Idseccion)" 
        SelectCommand="SELECT * FROM [NodoTexto]" 
        UpdateCommand="UPDATE [NodoTexto] SET [Titulo] = @Titulo, [Contenido] = @Contenido, [Idseccion] = @Idseccion WHERE [IdTexto] = @IdTexto">
        <DeleteParameters>
            <asp:Parameter Name="IdTexto" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Titulo" Type="String" />
            <asp:Parameter Name="Contenido" Type="String" />
            <asp:Parameter Name="Idseccion" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Titulo" Type="String" />
            <asp:Parameter Name="Contenido" Type="String" />
            <asp:Parameter Name="Idseccion" Type="Int32" />
            <asp:Parameter Name="IdTexto" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlFoto" runat="server" 
        ConnectionString="<%$ ConnectionStrings:Rpp_DbConn %>" 
        DeleteCommand="DELETE FROM [NodoImagenes] WHERE [Idimagen] = @Idimagen" 
        InsertCommand="INSERT INTO [NodoImagenes] ([Link], [Descripcion], [Idseccion]) VALUES (@Link, @Descripcion, @Idseccion)" 
        SelectCommand="SELECT * FROM [NodoImagenes]" 
        UpdateCommand="UPDATE [NodoImagenes] SET [Link] = @Link, [Descripcion] = @Descripcion, [Idseccion] = @Idseccion WHERE [Idimagen] = @Idimagen">
        <DeleteParameters>
            <asp:Parameter Name="Idimagen" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Link" Type="String" />
            <asp:Parameter Name="Descripcion" Type="String" />
            <asp:Parameter Name="Idseccion" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Link" Type="String" />
            <asp:Parameter Name="Descripcion" Type="String" />
            <asp:Parameter Name="Idseccion" Type="Int32" />
            <asp:Parameter Name="Idimagen" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
<div id="_pestania1">
        <asp:SqlDataSource ID="SQLVideo" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Rpp_DbConn %>" 
            DeleteCommand="DELETE FROM [NodoVideos] WHERE [Idvideo] = @Idvideo" 
            InsertCommand="INSERT INTO [NodoVideos] ([Link], [Descripcion], [Idseccion]) VALUES (@Link, @Descripcion, @Idseccion)" 
            SelectCommand="SELECT * FROM [NodoVideos]" 
            
            UpdateCommand="UPDATE [NodoVideos] SET [Link] = @Link, [Descripcion] = @Descripcion, [Idseccion] = @Idseccion WHERE [Idvideo] = @Idvideo">
            <DeleteParameters>
                <asp:Parameter Name="Idvideo" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Link" Type="String" />
                <asp:Parameter Name="Descripcion" Type="String" />
                <asp:Parameter Name="Idseccion" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Link" Type="String" />
                <asp:Parameter Name="Descripcion" Type="String" />
                <asp:Parameter Name="Idseccion" Type="Int32" />
                <asp:Parameter Name="Idvideo" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</div>
<div id="Div2">
        <asp:SqlDataSource ID="SqlRecolector" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Rpp_DbConn %>" 
            DeleteCommand="DELETE FROM [Recolector] WHERE [IdRecolector] = @IdRecolector" 
            InsertCommand="INSERT INTO [Recolector] ([Idtexto], [Idvideo], [Idseccion], [Fecha], [Prioridad], [NombreReportero]) VALUES (@Idtexto, @Idvideo, @Idseccion, @Fecha, @Prioridad, @NombreReportero)" 
            SelectCommand="SELECT * FROM [Recolector]" 
            
            UpdateCommand="UPDATE [Recolector] SET [Idtexto] = @Idtexto, [Idvideo] = @Idvideo, [Idseccion] = @Idseccion, [Fecha] = @Fecha, [Prioridad] = @Prioridad, [NombreReportero] = @NombreReportero WHERE [IdRecolector] = @IdRecolector">
            <DeleteParameters>
                <asp:Parameter Name="IdRecolector" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Idtexto" Type="Int32" />
                <asp:Parameter Name="Idvideo" Type="Int32" />
                <asp:Parameter Name="Idseccion" Type="Int32" />
                <asp:Parameter Name="Fecha" Type="DateTime" />
                <asp:Parameter Name="Prioridad" Type="String" />
                <asp:Parameter Name="NombreReportero" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Idtexto" Type="Int32" />
                <asp:Parameter Name="Idvideo" Type="Int32" />
                <asp:Parameter Name="Idseccion" Type="Int32" />
                <asp:Parameter Name="Fecha" Type="DateTime" />
                <asp:Parameter Name="Prioridad" Type="String" />
                <asp:Parameter Name="NombreReportero" Type="String" />
                <asp:Parameter Name="IdRecolector" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    <//div>
    <div id="Div3">
        To learn more about ASP.NET visit  </div>
    <p>
        You can also find <a href="http://go.micro.
        <asp:SqlDataSource ID="SqlUltimoVideo" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Rpp_DbConn %>" 
            SelectCommand="SELECT TOP (1) Idvideo AS ultimo FROM NodoVideos ORDER BY ultimo DESC">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlUltimoTexto" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RppDbConnectionString %>" 
            SelectCommand="SELECT IdTexto AS ultimo FROM NodoTexto ORDER BY ultimo DESC">
        </asp:SqlDataSource>
    </div>
    <p>
        You can also find            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
</asp:Content>
 