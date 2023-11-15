namespace Aplicacion
{
    partial class FormVoleibolista
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
            label5 = new Label();
            label6 = new Label();
            cmbMano = new ComboBox();
            txtPosicion = new TextBox();
            SuspendLayout();
            // 
            // cmbNacionalidades
            // 
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(118, 427);
            btnAgregar.Click += btnAgregar_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 273);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Mano";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 339);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Posicion";
            // 
            // cmbMano
            // 
            cmbMano.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMano.FormattingEnabled = true;
            cmbMano.Location = new Point(98, 297);
            cmbMano.Name = "cmbMano";
            cmbMano.Size = new Size(142, 23);
            cmbMano.TabIndex = 11;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(98, 369);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(142, 23);
            txtPosicion.TabIndex = 12;
            // 
            // FormVoleibolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 501);
            Controls.Add(txtPosicion);
            Controls.Add(cmbMano);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "FormVoleibolista";
            Text = "FormVoleibolista";
            Load += FormVoleibolista_Load;
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
            Controls.SetChildIndex(cmbMano, 0);
            Controls.SetChildIndex(txtPosicion, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private ComboBox cmbMano;
        private TextBox txtPosicion;
    }
}