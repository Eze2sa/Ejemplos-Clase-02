using System;

namespace InLineCode_CodeBehind
{
    public partial class EjemploClase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Ejemplo no asociado directamente a la pantalla .aspx");
        }
    }


    public partial class EjemploClase2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Estoy utilizando una segunda clase de un archivo no asociado directamente a la pantalla");
        }
    }
}