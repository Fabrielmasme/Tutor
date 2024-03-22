namespace Vista
{
    partial class LoginEstudiante
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
            btbIniciarSesionEstudiante = new Button();
            tbxEmail = new TextBox();
            lblLogin = new Label();
            tbxContraseña = new TextBox();
            btnAtrasInicio = new Button();
            btnOlvidasteContraseña = new Button();
            btnNoTengoCuenta = new Button();
            SuspendLayout();
            // 
            // btbIniciarSesionEstudiante
            // 
            btbIniciarSesionEstudiante.Location = new Point(12, 175);
            btbIniciarSesionEstudiante.Name = "btbIniciarSesionEstudiante";
            btbIniciarSesionEstudiante.Size = new Size(225, 37);
            btbIniciarSesionEstudiante.TabIndex = 0;
            btbIniciarSesionEstudiante.Text = "INICIAR SESIÓN";
            btbIniciarSesionEstudiante.UseVisualStyleBackColor = true;
            btbIniciarSesionEstudiante.Click += button1_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.BorderStyle = BorderStyle.FixedSingle;
            tbxEmail.Location = new Point(17, 77);
            tbxEmail.Margin = new Padding(5, 3, 3, 3);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Ingrese Email:";
            tbxEmail.Size = new Size(225, 23);
            tbxEmail.TabIndex = 2;
            tbxEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Location = new Point(108, 42);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(42, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // tbxContraseña
            // 
            tbxContraseña.BorderStyle = BorderStyle.FixedSingle;
            tbxContraseña.Location = new Point(17, 126);
            tbxContraseña.Margin = new Padding(5, 3, 3, 3);
            tbxContraseña.Name = "tbxContraseña";
            tbxContraseña.PlaceholderText = "Ingrese Contraseña:";
            tbxContraseña.Size = new Size(225, 23);
            tbxContraseña.TabIndex = 3;
            tbxContraseña.TextChanged += tbxContraseña_TextChanged;
            // 
            // btnAtrasInicio
            // 
            btnAtrasInicio.Location = new Point(14, 12);
            btnAtrasInicio.Name = "btnAtrasInicio";
            btnAtrasInicio.Size = new Size(50, 23);
            btnAtrasInicio.TabIndex = 4;
            btnAtrasInicio.Text = "ATRAS";
            btnAtrasInicio.UseVisualStyleBackColor = true;
            btnAtrasInicio.Click += btnAtrasInicio_Click;
            // 
            // btnOlvidasteContraseña
            // 
            btnOlvidasteContraseña.Location = new Point(48, 236);
            btnOlvidasteContraseña.Name = "btnOlvidasteContraseña";
            btnOlvidasteContraseña.Size = new Size(153, 23);
            btnOlvidasteContraseña.TabIndex = 5;
            btnOlvidasteContraseña.Text = "¿Olvidaste tu contraseña?";
            btnOlvidasteContraseña.UseVisualStyleBackColor = true;
            btnOlvidasteContraseña.Click += btnOlvidasteContraseña_Click;
            // 
            // btnNoTengoCuenta
            // 
            btnNoTengoCuenta.Location = new Point(48, 275);
            btnNoTengoCuenta.Name = "btnNoTengoCuenta";
            btnNoTengoCuenta.Size = new Size(153, 23);
            btnNoTengoCuenta.TabIndex = 6;
            btnNoTengoCuenta.Text = "No tengo una cuenta";
            btnNoTengoCuenta.UseVisualStyleBackColor = true;
            btnNoTengoCuenta.Click += btnNoTengoCuenta_Click;
            // 
            // LoginEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(254, 310);
            Controls.Add(btnNoTengoCuenta);
            Controls.Add(btnOlvidasteContraseña);
            Controls.Add(btnAtrasInicio);
            Controls.Add(tbxContraseña);
            Controls.Add(tbxEmail);
            Controls.Add(lblLogin);
            Controls.Add(btbIniciarSesionEstudiante);
            Name = "LoginEstudiante";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbIniciarSesionEstudiante;
        private TextBox tbxEmail;
        private Label lblLogin;
        private TextBox tbxContraseña;
        private Button btnAtrasInicio;
        private Button btnOlvidasteContraseña;
        private Button btnNoTengoCuenta;
    }
}