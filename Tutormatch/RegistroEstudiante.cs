using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutormatch;

namespace Vista
{
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
        }
        private void btnAtrasLogin_Click(object sender, EventArgs e)
        {
            Inicio irInicio = new Inicio();
            irInicio.Show(); //El evento show lo que hace es  hacer visible el formulario al usuario para poder interactuar solo con ese. 
            this.Hide(); //El evento hide hace invisible a los demas formularios que no se usan o están detras del que el usuario está usando
        }

        private void btnConfirmarRegistroEstudiante_Click(object sender, EventArgs e)
        {
            LoginEstudiante irALoginEstudiante = new LoginEstudiante();
            irALoginEstudiante.Show();
            this.Hide();
        }
    }
}