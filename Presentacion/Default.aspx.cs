using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using LogicaNegocio;

namespace Presentacion
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            DeportistaBL bl = new DeportistaBL();
            List<deportista> listaDeportita = bl.GetAll();
            foreach (deportista D in listaDeportita)
            {
                DDLDeportistas.Items.Add(D.nombre_deportista);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            PaisBL bl = new PaisBL();
            Pais pais = new Pais();
            pais.id_pais = txtCodigo.Text;
            pais.nombre_pais=txtNombrePais.Text;
            pais.continente=txtContinente.Text;

            String resultado=bl.AdicionarValido(pais);
            lblResultado.Text=resultado;
            limpiarForm();
        }        
        private void limpiarForm()
        {
            txtCodigo.Text=txtNombrePais.Text=txtContinente.Text="";
        }
    }
}