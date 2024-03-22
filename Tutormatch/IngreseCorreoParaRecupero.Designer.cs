namespace Vista
{
    partial class IngreseCorreoParaRecupero
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
            lblIngreseCorreo = new Label();
            btnAtrasLogin = new Button();
            btnEnviar = new Button();
            tbxEmail = new TextBox();
            SuspendLayout();
            // 
            // lblIngreseCorreo
            // 
            lblIngreseCorreo.AutoSize = true;
            lblIngreseCorreo.BackColor = Color.White;
            lblIngreseCorreo.ForeColor = Color.Black;
            lblIngreseCorreo.Location = new Point(34, 99);
            lblIngreseCorreo.Name = "lblIngreseCorreo";
            lblIngreseCorreo.Size = new Size(198, 15);
            lblIngreseCorreo.TabIndex = 0;
            lblIngreseCorreo.Text = "INGRESE SU CORREO ELECTRONICO";
            // 
            // btnAtrasLogin
            // 
            btnAtrasLogin.Location = new Point(34, 33);
            btnAtrasLogin.Name = "btnAtrasLogin";
            btnAtrasLogin.Size = new Size(43, 23);
            btnAtrasLogin.TabIndex = 1;
            btnAtrasLogin.Text = "Atras";
            btnAtrasLogin.UseVisualStyleBackColor = true;
            btnAtrasLogin.Click += btnAtrasLogin_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(34, 268);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(198, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(34, 152);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Email :";
            tbxEmail.Size = new Size(198, 23);
            tbxEmail.TabIndex = 3;
            // 
            // IngreseCorreoParaRecupero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(264, 362);
            Controls.Add(tbxEmail);
            Controls.Add(btnEnviar);
            Controls.Add(btnAtrasLogin);
            Controls.Add(lblIngreseCorreo);
            Name = "IngreseCorreoParaRecupero";
            Text = "IngreseCorreoParaRecupero";
            Load += IngreseCorreoParaRecupero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreseCorreo;
        private Button btnAtrasLogin;
        private Button btnEnviar;
        private TextBox tbxEmail;
    }
}