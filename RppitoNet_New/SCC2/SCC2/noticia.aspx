<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="noticia.aspx.cs" Inherits="SCC2.noticia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Noticias</title>
    <script language="javascript" type="text/jscript">

        function VisibleDiv(id) {

            var div1 = document.getElementById('_pestania1');

            var div2 = document.getElementById('_pestania2');

            var div3 = document.getElementById('_pestania3');

            div1.style.display = 'none';

            div2.style.display = 'none';

            div3.style.display = 'none';

            if (div1.id == id)

                div1.style.display = 'block';

            if (div2.id == id)

                div2.style.display = 'block';

            if (div3.id == id)

                div3.style.display = 'block';

        }

</script>

 
</head>
<body>
   <form id="form1" runat="server">

<asp:Button ID="_pestania1Btn" runat="server" OnClientClick="VisibleDiv('_pestania1');return false;" Text="Pest 1" />

<asp:Button ID="_pestania2Btn" runat="server" OnClientClick="VisibleDiv('_pestania2');return false;" Text="Pest 2" />

<asp:Button ID="_pestania3Btn" runat="server" OnClientClick="VisibleDiv('_pestania3');return false;" Text="Pest 3" />

    <div id="_pestania1">

    1

    </div>

    <div id="_pestania2" style="display:none;">

    2

    </div>

    <div id="_pestania3" style="display:none;">

    3

    </div>

</form>
</body>
</html>
