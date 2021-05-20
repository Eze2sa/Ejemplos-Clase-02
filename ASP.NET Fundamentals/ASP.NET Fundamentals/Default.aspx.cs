using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Fundamentals
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitas.Text = string.Concat("Cantidad de Visitas: ", Application["Visitas"]);

            lblKeyWebConfig.Text = string.Concat("Key: ", WebConfigurationManager.AppSettings["EjemploKey"]);
        }

        public void DispararError(object sender, EventArgs e)
        {
            throw new Exception("Error Forzado");
        }
    }
}