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
            // init const / misc
            IEnumMisc _indexConst = new IndexConst(),
                      _tipoSangre = new TipoSangre();
            // init components Labels index GUI
            LblIdPaciente.Text = _indexConst.GetValue(0);
            LblPNombre.Text = _indexConst.GetValue(1);
            LblSNombre.Text = _indexConst.GetValue(2);
            LblPApellido.Text = _indexConst.GetValue(3);
            LblSApellido.Text = _indexConst.GetValue(4);
            LblEdad.Text = _indexConst.GetValue(5);
            LblTipoSangre.Text = _indexConst.GetValue(6);
            BtnRegistrarFicha.Text = _indexConst.GetValue(7);

            // init components TextBox index GUI
            TxtIdPaciente.Text = DateTime.Now.Ticks.ToString();
            TxtIdPaciente.Enabled = false;

            // init components DropDownList index GUI
            DrpTipoSangre.DataSource = _tipoSangre.ToList();
            DrpTipoSangre.DataBind();
        }
        // ejemplo Hash Generator
        /*
        private long Hash(in long seed)
        {
            return long.Parse(Math.Ceiling(Math.Sin(seed)).ToString());
        }*/

        protected void BtnRegistrarFicha_Click(object sender, EventArgs e)
        {

        }
    }
}