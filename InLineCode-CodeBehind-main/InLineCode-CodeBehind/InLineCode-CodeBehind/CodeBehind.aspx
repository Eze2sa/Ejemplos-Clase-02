<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CodeBehind.aspx.cs" Inherits="InLineCode_CodeBehind.CodeBehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:textbox id="txtEjemplo" text="Código detrás del modelo" runat="server" Width="20%"></asp:textbox>
        </div>
        <br/>
        <div>
            <asp:button id="btnEjemplo" text="Botón de Ejemplo" OnClick="btnEjemplo_Click" runat="server"></asp:button>
        </div>
        <br />
        <div>
            <asp:label id="lblEjemplo" runat="server"></asp:label>
        </div>
    </form>
</body>
</html>
