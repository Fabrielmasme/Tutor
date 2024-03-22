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
    public partial class CambioDeContraseña : Form
    {
        public CambioDeContraseña()
        {
            InitializeComponent();
        }

        private void btnAtrasIngreseCorreo_Click(object sender, EventArgs e)
        {
            IngreseCodigo irAIngreseCodigo = new IngreseCodigo();
            irAIngreseCodigo.Show();
            this.Hide();
        }

        private void btnConfirmarContraseña_Click(object sender, EventArgs e)
        {
            LoginEstudiante irALoginEstudiante = new LoginEstudiante();
            irALoginEstudiante.Show();
            this.Hide();
        }
    }
}
