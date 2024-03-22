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
    public partial class IngreseCorreoParaRecupero : Form
    {
        public IngreseCorreoParaRecupero()
        {
            InitializeComponent();
        }

        private void IngreseCorreoParaRecupero_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IngreseCodigo irAIngreseCorreo = new IngreseCodigo();
            irAIngreseCorreo.Show();
            this.Hide();
        }

        private void btnAtrasLogin_Click(object sender, EventArgs e)
        {
            LoginEstudiante irALoginEstudiante = new LoginEstudiante();
            irALoginEstudiante.Show();
            this.Hide();
        }
    }
}
