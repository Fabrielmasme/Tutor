namespace Vista
{
    partial class IngreseCodigo
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
            tbxCodigo = new TextBox();
            btnConfirmar = new Button();
            btnAtrasIngreseCorreo = new Button();
            lblEnvioDeCodigo = new Label();
            lblConsultarCorreo = new Label();
            SuspendLayout();
            // 
            // tbxCodigo
            // 
            tbxCodigo.Location = new Point(37, 213);
            tbxCodigo.Name = "tbxCodigo";
            tbxCodigo.PlaceholderText = "Ingrese Codigo :";
            tbxCodigo.Size = new Size(218, 23);
            tbxCodigo.TabIndex = 7;
            tbxCodigo.TextChanged += tbxEmail_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(37, 283);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(218, 23);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAtrasIngreseCorreo
            // 
            btnAtrasIngreseCorreo.Location = new Point(12, 12);
            btnAtrasIngreseCorreo.Name = "btnAtrasIngreseCorreo";
            btnAtrasIngreseCorreo.Size = new Size(43, 23);
            btnAtrasIngreseCorreo.TabIndex = 5;
            btnAtrasIngreseCorreo.Text = "Atras";
            btnAtrasIngreseCorreo.UseVisualStyleBackColor = true;
            btnAtrasIngreseCorreo.Click += btnAtrasIngreseCorreo_Click;
            // 
            // lblEnvioDeCodigo
            // 
            lblEnvioDeCodigo.AutoSize = true;
            lblEnvioDeCodigo.BackColor = Color.White;
            lblEnvioDeCodigo.ForeColor = Color.Black;
            lblEnvioDeCodigo.Location = new Point(61, 114);
            lblEnvioDeCodigo.Name = "lblEnvioDeCodigo";
            lblEnvioDeCodigo.Size = new Size(149, 15);
            lblEnvioDeCodigo.TabIndex = 4;
            lblEnvioDeCodigo.Text = "TE ENVIAMOS UN CODIGO";
            // 
            // lblConsultarCorreo
            // 
            lblConsultarCorreo.AutoSize = true;
            lblConsultarCorreo.BackColor = Color.White;
            lblConsultarCorreo.ForeColor = Color.Black;
            lblConsultarCorreo.Location = new Point(37, 147);
            lblConsultarCorreo.Name = "lblConsultarCorreo";
            lblConsultarCorreo.Size = new Size(218, 30);
            lblConsultarCorreo.TabIndex = 8;
            lblConsultarCorreo.Text = "Consulte su correo electronico \r\npara obtener tu codigo de confirmacion";
            lblConsultarCorreo.Click += lblConsultarCorreo_Click;
            // 
            // IngreseCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(293, 371);
            Controls.Add(lblConsultarCorreo);
            Controls.Add(tbxCodigo);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAtrasIngreseCorreo);
            Controls.Add(lblEnvioDeCodigo);
            Name = "IngreseCodigo";
            Text = "IngreseCodigo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxCodigo;
        private Button btnConfirmar;
        private Button btnAtrasIngreseCorreo;
        private Label lblEnvioDeCodigo;
        private Label lblConsultarCorreo;
    }
}