namespace Aplicacion
{
    public partial class FormDatosJugadores
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
        protected void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cmbNacionalidades = new ComboBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 149);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 212);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Nacionalidad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(98, 174);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Entre 18 y 50...";
            txtEdad.Size = new Size(142, 23);
            txtEdad.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 115);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(142, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 23);
            txtNombre.TabIndex = 6;
            // 
            // cmbNacionalidades
            // 
            cmbNacionalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidades.FormattingEnabled = true;
            cmbNacionalidades.Location = new Point(98, 230);
            cmbNacionalidades.Name = "cmbNacionalidades";
            cmbNacionalidades.Size = new Size(142, 23);
            cmbNacionalidades.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(112, 302);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 41);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormDatosJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 371);
            Controls.Add(btnAgregar);
            Controls.Add(cmbNacionalidades);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDatosJugadores";
            Text = "FormDatosJugadores";
            Load += FormDatosJugadores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label label4;
        protected TextBox txtEdad;
        protected TextBox txtApellido;
        protected TextBox txtNombre;
        protected ComboBox cmbNacionalidades;
        protected Button btnAgregar;
    }
}