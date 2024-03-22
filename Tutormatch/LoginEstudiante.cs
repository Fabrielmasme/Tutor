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
    public partial class LoginEstudiante : Form
    {
        public LoginEstudiante()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtrasInicio_Click(object sender, EventArgs e)
        {
            Inicio irInicio = new Inicio();
            irInicio.Show(); //El evento show lo que hace es  hacer visible el formulario al usuario para poder interactuar solo con ese. 
            this.Hide(); //El evento hide hace invisible a los demas formularios que no se usan o están detras del que el usuario está usando
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeEstudiante irAHome = new HomeEstudiante();
            irAHome.Show();
            this.Hide();
        }

        private void tbxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOlvidasteContraseña_Click(object sender, EventArgs e)
        {
            IngreseCorreoParaRecupero irAIngreseCorreo = new IngreseCorreoParaRecupero();
            irAIngreseCorreo.Show();
            this.Hide();
        }

        private void btnNoTengoCuenta_Click(object sender, EventArgs e)
        {
            RegistroEstudiante irAHome = new RegistroEstudiante();
            irAHome.Show();
            this.Hide();
        }
    }
}
