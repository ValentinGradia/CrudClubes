namespace Aplicacion
{
    partial class FormCrearEquipo
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
            btnAceptar = new Button();
            txtCantJugadores = new TextBox();
            txtNombreEquipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.InactiveBorder;
            btnAceptar.Font = new Font("Myanmar Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(124, 151);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(92, 47);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Crear";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCantJugadores
            // 
            txtCantJugadores.Location = new Point(209, 94);
            txtCantJugadores.Name = "txtCantJugadores";
            txtCantJugadores.Size = new Size(133, 23);
            txtCantJugadores.TabIndex = 1;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(12, 94);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(125, 23);
            txtNombreEquipo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre del equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(209, 62);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad maxima de jugadores";
            // 
            // FormCrearEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(406, 241);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreEquipo);
            Controls.Add(txtCantJugadores);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCrearEquipo";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtCantJugadores;
        private TextBox txtNombreEquipo;
        private Label label1;
        private Label label2;
    }
}