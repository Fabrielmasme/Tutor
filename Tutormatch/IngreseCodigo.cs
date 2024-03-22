using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class IngreseCodigo : Form
    {
        public IngreseCodigo()
        {
            InitializeComponent();
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConsultarCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnAtrasIngreseCorreo_Click(object sender, EventArgs e)
        {
            IngreseCorreoParaRecupero irAIngreseCorreo = new IngreseCorreoParaRecupero();
            irAIngreseCorreo.Show();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CambioDeContraseña irALoginEstudiante = new CambioDeContraseña();
            irALoginEstudiante.Show();
            this.Hide();
        }
    }
}
