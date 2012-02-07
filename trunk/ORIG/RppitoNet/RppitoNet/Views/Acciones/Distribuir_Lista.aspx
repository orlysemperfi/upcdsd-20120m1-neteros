<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Distribuir_Lista
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>Distribuir_Lista&nbsp;&nbsp;&nbsp; </h2>
    <p>
        <asp:GridView ID="gdvListado" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" Width="629px">
            <Columns>
                <asp:BoundField HeaderText="Código">
                <HeaderStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Titulo">
                <HeaderStyle Width="60%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Fecha">
                <HeaderStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Sección">
                <HeaderStyle Width="15%" />
                </asp:BoundField>
                <asp:CheckBoxField HeaderText="Twitter">
                <HeaderStyle Width="5%" />
                </asp:CheckBoxField>
                <asp:ButtonField Text="Detalle" />
            </Columns>
        </asp:GridView>
    </p>

    </form>

</asp:Content>
