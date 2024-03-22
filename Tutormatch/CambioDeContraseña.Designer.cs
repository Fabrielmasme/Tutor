namespace Vista
{
    partial class CambioDeContraseña
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
            tbxNuevaContraseña = new TextBox();
            btnConfirmarContraseña = new Button();
            btnAtrasIngreseCorreo = new Button();
            lblContraseñaNueva = new Label();
            tbxConfirmeContraseña = new TextBox();
            SuspendLayout();
            // 
            // tbxNuevaContraseña
            // 
            tbxNuevaContraseña.Location = new Point(28, 137);
            tbxNuevaContraseña.Name = "tbxNuevaContraseña";
            tbxNuevaContraseña.PlaceholderText = "Ingrese una nueva contraseña :";
            tbxNuevaContraseña.Size = new Size(218, 23);
            tbxNuevaContraseña.TabIndex = 12;
            // 
            // btnConfirmarContraseña
            // 
            btnConfirmarContraseña.Location = new Point(28, 255);
            btnConfirmarContraseña.Name = "btnConfirmarContraseña";
            btnConfirmarContraseña.Size = new Size(218, 23);
            btnConfirmarContraseña.TabIndex = 11;
            btnConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
            btnConfirmarContraseña.UseVisualStyleBackColor = true;
            btnConfirmarContraseña.Click += btnConfirmarContraseña_Click;
            // 
            // btnAtrasIngreseCorreo
            // 
            btnAtrasIngreseCorreo.Location = new Point(12, 12);
            btnAtrasIngreseCorreo.Name = "btnAtrasIngreseCorreo";
            btnAtrasIngreseCorreo.Size = new Size(43, 23);
            btnAtrasIngreseCorreo.TabIndex = 10;
            btnAtrasIngreseCorreo.Text = "Atras";
            btnAtrasIngreseCorreo.UseVisualStyleBackColor = true;
            btnAtrasIngreseCorreo.Click += btnAtrasIngreseCorreo_Click;
            // 
            // lblContraseñaNueva
            // 
            lblContraseñaNueva.AutoSize = true;
            lblContraseñaNueva.BackColor = Color.White;
            lblContraseñaNueva.ForeColor = Color.Black;
            lblContraseñaNueva.Location = new Point(44, 76);
            lblContraseñaNueva.Name = "lblContraseñaNueva";
            lblContraseñaNueva.Size = new Size(183, 15);
            lblContraseñaNueva.TabIndex = 9;
            lblContraseñaNueva.Text = "ELIGE UNA CONTRASEÑA NUEVA";
            // 
            // tbxConfirmeContraseña
            // 
            tbxConfirmeContraseña.Location = new Point(28, 194);
            tbxConfirmeContraseña.Name = "tbxConfirmeContraseña";
            tbxConfirmeContraseña.PlaceholderText = "Confirme la nueva contraseña :";
            tbxConfirmeContraseña.Size = new Size(218, 23);
            tbxConfirmeContraseña.TabIndex = 13;
            // 
            // CambioDeContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(272, 318);
            Controls.Add(tbxConfirmeContraseña);
            Controls.Add(tbxNuevaContraseña);
            Controls.Add(btnConfirmarContraseña);
            Controls.Add(btnAtrasIngreseCorreo);
            Controls.Add(lblContraseñaNueva);
            Name = "CambioDeContraseña";
            Text = "CambioDeContraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNuevaContraseña;
        private Button btnConfirmarContraseña;
        private Button btnAtrasIngreseCorreo;
        private Label lblContraseñaNueva;
        private TextBox tbxConfirmeContraseña;
    }
}