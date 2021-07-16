using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace FichaMedica
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // init components Labels index GUI
            LblIdPaciente.Text = IndexConst.GetValue(0);
            LblPNombre.Text = IndexConst.GetValue(1);
            LblSNombre.Text = IndexConst.GetValue(2);
            LblPApellido.Text = IndexConst.GetValue(3);
            LblSApellido.Text = IndexConst.GetValue(4);
            LblEdad.Text = IndexConst.GetValue(5);
            LblTipoSangre.Text = IndexConst.GetValue(6);
            BtnRegistrarFicha.Text = IndexConst.GetValue(7);

            // init components TextBox index GUI
            TxtIdPaciente.Text = DateTime.Now.Ticks.ToString();
            TxtIdPaciente.Enabled = false;
        }
        // ejemplo Hash Generator
        private long Hash(in long seed)
        {
            return long.Parse(Math.Ceiling(Math.Sin(seed)).ToString());
        }

        protected void BtnRegistrarFicha_Click(object sender, EventArgs e)
        {

        }
    }
}