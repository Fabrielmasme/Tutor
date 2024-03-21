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
            button1 = new Button();
            txtEmail = new TextBox();
            lblLogin = new Label();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 243);
            button1.Name = "button1";
            button1.Size = new Size(225, 37);
            button1.TabIndex = 0;
            button1.Text = "INICIAR SESIÓN";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(14, 85);
            txtEmail.Margin = new Padding(5, 3, 3, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese Email:";
            txtEmail.Size = new Size(225, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(108, 29);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(42, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(14, 152);
            txtContraseña.Margin = new Padding(5, 3, 3, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Ingrese Contraseña:";
            txtContraseña.Size = new Size(225, 23);
            txtContraseña.TabIndex = 3;
            // 
            // LoginEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Controls.Add(button1);
            Name = "LoginEstudiante";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtEmail;
        private Label lblLogin;
        private TextBox txtContraseña;
    }
}