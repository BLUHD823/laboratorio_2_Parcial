namespace Paiva.Alejo.A23
{
    partial class Form1
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
            lblMedicos = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            lblPacientes = new Label();
            btnAtender = new Button();
            btnSalir = new Button();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(92, 15);
            lblMedicos.TabIndex = 0;
            lblMedicos.Text = "PersonalMedico";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 27);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(170, 124);
            lstMedicos.TabIndex = 1;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(214, 27);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(170, 124);
            lstPacientes.TabIndex = 3;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(214, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 2;
            lblPacientes.Text = "Pacientes";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(399, 27);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(120, 23);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(399, 157);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 158);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(372, 96);
            rtbInfoMedico.TabIndex = 7;
            rtbInfoMedico.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 300);
            Controls.Add(rtbInfoMedico);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lstPacientes);
            Controls.Add(lblPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblMedicos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedicos;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Label lblPacientes;
        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox rtbInfoMedico;
    }
}