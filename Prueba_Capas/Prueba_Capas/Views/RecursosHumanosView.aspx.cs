using Prueba_Capas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Capas.Views
{
    public partial class RecursosHumanosView : System.Web.UI.Page
    {
        private RecursosHumanosController controladoraRH = new RecursosHumanosController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            List<String> telefonos = new List<String>();

            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApe1.Text != "" && txtApe2.Text != "")
            {
                if (txtTel1.Text != null) { telefonos.Add(txtTel1.Text);}
                if (txtTel2.Text != null) { telefonos.Add(txtTel2.Text);}

                resultado = controladoraRH.insertarRecursoHumano(txtCedula.Text, txtNombre.Text, txtApe1.Text, txtApe2.Text, telefonos);

                if (resultado)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Popup", "successalert();", true);
                    limpiarCampos();
                }
            }
        }

        protected void limpiarCampos() {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApe1.Text = "";
            txtApe2.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
        }

        
    }
}