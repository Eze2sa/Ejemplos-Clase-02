<%@ Language=C# %>
<HTML>
    <script runat="server" language="C#">
        void onClickEjemplo(Object sender, EventArgs e)
        {
            lblEjemplo.Text = txtEjemplo.Text.ToString();
        }
    </script>

    <body>
        <form id="formulario" runat="server">
            <div>
            <asp:textbox id="txtEjemplo" text="Código en línea" runat="server"></asp:textbox>
            </div>
            <br />
            <div>
            <asp:button id="btnEjemplo" text="Botón de Ejemplo" OnClick="onClickEjemplo" runat="server"></asp:button>
            </div>
            <br />
            <div>
            <asp:label id="lblEjemplo" runat="server"></asp:label>
            </div>
        </form>
    </body>
</HTML>

