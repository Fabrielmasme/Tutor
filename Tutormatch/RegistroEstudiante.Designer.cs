namespace Vista
{
    partial class RegistroEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistro = new Label();
            btnAtrasLogin = new Button();
            tbxNombreApellido = new TextBox();
            tbxConfirmarContraseña = new TextBox();
            tbxContraseña = new TextBox();
            tbxEmail = new TextBox();
            tbxDNI = new TextBox();
            btnConfirmarRegistroEstudiante = new Button();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.BackColor = Color.White;
            lblRegistro.Location = new Point(76, 53);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(59, 15);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "REGISTRO";
            // 
            // btnAtrasLogin
            // 
            btnAtrasLogin.Location = new Point(14, 11);
            btnAtrasLogin.Name = "btnAtrasLogin";
            btnAtrasLogin.Size = new Size(75, 23);
            btnAtrasLogin.TabIndex = 1;
            btnAtrasLogin.Text = "Atras";
            btnAtrasLogin.UseVisualStyleBackColor = true;
            btnAtrasLogin.Click += btnAtrasLogin_Click;
            // 
            // tbxNombreApellido
            // 
            tbxNombreApellido.Location = new Point(14, 98);
            tbxNombreApellido.Name = "tbxNombreApellido";
            tbxNombreApellido.PlaceholderText = "Nombre y Apellido :";
            tbxNombreApellido.Size = new Size(198, 23);
            tbxNombreApellido.TabIndex = 2;
            // 
            // tbxConfirmarContraseña
            // 
            tbxConfirmarContraseña.Location = new Point(14, 294);
            tbxConfirmarContraseña.Name = "tbxConfirmarContraseña";
            tbxConfirmarContraseña.PlaceholderText = "Confirmar Contraseña :";
            tbxConfirmarContraseña.Size = new Size(198, 23);
            tbxConfirmarContraseña.TabIndex = 3;
            // 
            // tbxContraseña
            // 
            tbxContraseña.Location = new Point(14, 242);
            tbxContraseña.Name = "tbxContraseña";
            tbxContraseña.PlaceholderText = "Contraseña :";
            tbxContraseña.Size = new Size(198, 23);
            tbxContraseña.TabIndex = 4;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(14, 194);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Email :";
            tbxEmail.Size = new Size(198, 23);
            tbxEmail.TabIndex = 5;
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(14, 148);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.PlaceholderText = "D.N.I :";
            tbxDNI.Size = new Size(198, 23);
            tbxDNI.TabIndex = 6;
            // 
            // btnConfirmarRegistroEstudiante
            // 
            btnConfirmarRegistroEstudiante.Location = new Point(14, 387);
            btnConfirmarRegistroEstudiante.Name = "btnConfirmarRegistroEstudiante";
            btnConfirmarRegistroEstudiante.Size = new Size(198, 29);
            btnConfirmarRegistroEstudiante.TabIndex = 7;
            btnConfirmarRegistroEstudiante.Text = "CONFIRMAR";
            btnConfirmarRegistroEstudiante.UseVisualStyleBackColor = true;
            btnConfirmarRegistroEstudiante.Click += btnConfirmarRegistroEstudiante_Click;
            // 
            // RegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(226, 434);
            Controls.Add(btnConfirmarRegistroEstudiante);
            Controls.Add(tbxDNI);
            Controls.Add(tbxEmail);
            Controls.Add(tbxContraseña);
            Controls.Add(tbxConfirmarContraseña);
            Controls.Add(tbxNombreApellido);
            Controls.Add(btnAtrasLogin);
            Controls.Add(lblRegistro);
            Name = "RegistroEstudiante";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Button btnAtrasLogin;
        private TextBox tbxNombreApellido;
        private TextBox tbxConfirmarContraseña;
        private TextBox tbxContraseña;
        private TextBox tbxEmail;
        private TextBox tbxDNI;
        private Button btnConfirmarRegistroEstudiante;
    }
}