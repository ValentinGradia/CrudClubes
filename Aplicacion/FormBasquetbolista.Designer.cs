namespace Aplicacion
{
    partial class FormBasquetbolista
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
            txtCalzado = new TextBox();
            txtAltura = new TextBox();
            txtPosicion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(47, 33);
            // 
            // label2
            // 
            label2.Location = new Point(47, 97);
            // 
            // txtEdad
            // 
            txtEdad.PlaceholderText = "Entre 18 y 50";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(104, 454);
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtCalzado
            // 
            txtCalzado.Location = new Point(98, 339);
            txtCalzado.Name = "txtCalzado";
            txtCalzado.Size = new Size(142, 23);
            txtCalzado.TabIndex = 9;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(98, 285);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "En centimetros...";
            txtAltura.Size = new Size(142, 23);
            txtAltura.TabIndex = 10;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(98, 392);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.PlaceholderText = "Opcional";
            txtPosicion.Size = new Size(142, 23);
            txtPosicion.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 265);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Altura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 318);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "Calzado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(44, 369);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 14;
            label7.Text = "Posicion";
            // 
            // FormBasquetbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 527);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPosicion);
            Controls.Add(txtAltura);
            Controls.Add(txtCalzado);
            Name = "FormBasquetbolista";
            Text = "Basquetbolista";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(cmbNacionalidades, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(txtCalzado, 0);
            Controls.SetChildIndex(txtAltura, 0);
            Controls.SetChildIndex(txtPosicion, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalzado;
        private TextBox txtAltura;
        private TextBox txtPosicion;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}