namespace Aplicacion
{
    public partial class FormFutbolista
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
        /// 
        private void InitializeComponent()
        {
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtGoles = new TextBox();
            txtPosicion = new TextBox();
            cmbPierna = new ComboBox();
            SuspendLayout();
            // 
            // cmbNacionalidades
            // 
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(111, 460);
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 265);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Pierna";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 312);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "Goles";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 371);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 11;
            label7.Text = "Posicion";
            // 
            // txtGoles
            // 
            txtGoles.Location = new Point(98, 337);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(142, 23);
            txtGoles.TabIndex = 13;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(98, 403);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.PlaceholderText = "Opcional...";
            txtPosicion.Size = new Size(142, 23);
            txtPosicion.TabIndex = 14;
            // 
            // cmbPierna
            // 
            cmbPierna.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPierna.FormattingEnabled = true;
            cmbPierna.Location = new Point(98, 283);
            cmbPierna.Name = "cmbPierna";
            cmbPierna.Size = new Size(142, 23);
            cmbPierna.TabIndex = 15;
            // 
            // FormFutbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 527);
            Controls.Add(cmbPierna);
            Controls.Add(txtPosicion);
            Controls.Add(txtGoles);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormFutbolista";
            Text = "FormAgregarFutbolista";
            Load += FormAgregarFutbolista_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(cmbNacionalidades, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtGoles, 0);
            Controls.SetChildIndex(txtPosicion, 0);
            Controls.SetChildIndex(cmbPierna, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtGoles;
        private TextBox txtPosicion;
        private ComboBox cmbPierna;
    }
}