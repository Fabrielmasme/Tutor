namespace Tutormatch
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEstudiante = new Button();
            btnProfesor = new Button();
            txtQueEres = new Label();
            SuspendLayout();
            // 
            // btnEstudiante
            // 
            btnEstudiante.BackColor = Color.FromArgb(119, 221, 119);
            btnEstudiante.Location = new Point(32, 76);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(195, 23);
            btnEstudiante.TabIndex = 0;
            btnEstudiante.Text = "ESTUDIANTE";
            btnEstudiante.UseVisualStyleBackColor = false;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.BackColor = Color.FromArgb(119, 221, 119);
            btnProfesor.Location = new Point(32, 240);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(195, 23);
            btnProfesor.TabIndex = 1;
            btnProfesor.Text = "PROFESOR";
            btnProfesor.UseVisualStyleBackColor = false;
            // 
            // txtQueEres
            // 
            txtQueEres.AutoSize = true;
            txtQueEres.BackColor = Color.FromArgb(255, 241, 104);
            txtQueEres.BorderStyle = BorderStyle.FixedSingle;
            txtQueEres.Location = new Point(62, 164);
            txtQueEres.Name = "txtQueEres";
            txtQueEres.Size = new Size(125, 17);
            txtQueEres.TabIndex = 2;
            txtQueEres.Text = "¿Como queres iniciar?";
            txtQueEres.Click += txtQueEres_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(258, 318);
            Controls.Add(txtQueEres);
            Controls.Add(btnProfesor);
            Controls.Add(btnEstudiante);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEstudiante;
        private Button btnProfesor;
        private Label txtQueEres;
    }
}
