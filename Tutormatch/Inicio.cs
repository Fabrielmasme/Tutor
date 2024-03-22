using Vista;

namespace Tutormatch
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void txtQueEres_Click(object sender, EventArgs e)
        {

        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            LoginEstudiante irLogin = new LoginEstudiante();
            irLogin.Show();
            this.Hide();
        }
    }
}
