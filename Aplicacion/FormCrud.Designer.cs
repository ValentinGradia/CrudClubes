namespace Aplicacion
{
    partial class FormCrud
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
            lstEquipo = new ListBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregarEquipo = new Button();
            btnOrdenarEdadAscendente = new Button();
            btnOrdenarApellidosAscendente = new Button();
            label1 = new Label();
            label2 = new Label();
            btnOrdenarEdadDescendente = new Button();
            btnOrdenarApellidosDescendente = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstEquipo
            // 
            lstEquipo.Font = new Font("Cambria Math", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstEquipo.FormattingEnabled = true;
            lstEquipo.ItemHeight = 84;
            lstEquipo.Location = new Point(12, 12);
            lstEquipo.Name = "lstEquipo";
            lstEquipo.Size = new Size(997, 340);
            lstEquipo.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Location = new Point(28, 389);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 78);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Jugador";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            btnAgregar.MouseHover += btnAgregar_MouseHover;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ScrollBar;
            btnModificar.Location = new Point(161, 389);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 78);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Jugador";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseHover += btnModificar_MouseHover;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Location = new Point(312, 389);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 78);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Jugador";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseHover += btnEliminar_MouseHover;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.IndianRed;
            btnAgregarEquipo.ForeColor = SystemColors.ButtonFace;
            btnAgregarEquipo.Location = new Point(520, 378);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(131, 89);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar Club";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnOrdenarEdadAscendente
            // 
            btnOrdenarEdadAscendente.BackColor = Color.FromArgb(255, 192, 128);
            btnOrdenarEdadAscendente.Location = new Point(1015, 45);
            btnOrdenarEdadAscendente.Name = "btnOrdenarEdadAscendente";
            btnOrdenarEdadAscendente.Size = new Size(88, 53);
            btnOrdenarEdadAscendente.TabIndex = 5;
            btnOrdenarEdadAscendente.Text = "Ordenar por Edad";
            btnOrdenarEdadAscendente.UseVisualStyleBackColor = false;
            btnOrdenarEdadAscendente.Click += btnOrdenarEdadAscendente_Click;
            // 
            // btnOrdenarApellidosAscendente
            // 
            btnOrdenarApellidosAscendente.BackColor = Color.FromArgb(255, 224, 192);
            btnOrdenarApellidosAscendente.Location = new Point(1015, 104);
            btnOrdenarApellidosAscendente.Name = "btnOrdenarApellidosAscendente";
            btnOrdenarApellidosAscendente.Size = new Size(88, 55);
            btnOrdenarApellidosAscendente.TabIndex = 6;
            btnOrdenarApellidosAscendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosAscendente.UseVisualStyleBackColor = false;
            btnOrdenarApellidosAscendente.Click += btnOrdenarApellidosAscendente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1015, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Ascendente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1015, 194);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Descendente";
            // 
            // btnOrdenarEdadDescendente
            // 
            btnOrdenarEdadDescendente.BackColor = Color.FromArgb(255, 192, 128);
            btnOrdenarEdadDescendente.Location = new Point(1015, 223);
            btnOrdenarEdadDescendente.Name = "btnOrdenarEdadDescendente";
            btnOrdenarEdadDescendente.Size = new Size(88, 59);
            btnOrdenarEdadDescendente.TabIndex = 9;
            btnOrdenarEdadDescendente.Text = "Ordenar por Edad";
            btnOrdenarEdadDescendente.UseVisualStyleBackColor = false;
            btnOrdenarEdadDescendente.Click += btnOrdenarEdadDescendente_Click;
            // 
            // btnOrdenarApellidosDescendente
            // 
            btnOrdenarApellidosDescendente.BackColor = Color.FromArgb(255, 224, 192);
            btnOrdenarApellidosDescendente.Location = new Point(1015, 289);
            btnOrdenarApellidosDescendente.Name = "btnOrdenarApellidosDescendente";
            btnOrdenarApellidosDescendente.Size = new Size(88, 63);
            btnOrdenarApellidosDescendente.TabIndex = 10;
            btnOrdenarApellidosDescendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosDescendente.UseVisualStyleBackColor = false;
            btnOrdenarApellidosDescendente.Click += btnOrdenarApellidosDescendente_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(885, 388);
            button1.Name = "button1";
            button1.Size = new Size(103, 76);
            button1.TabIndex = 11;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1135, 492);
            Controls.Add(button1);
            Controls.Add(btnOrdenarApellidosDescendente);
            Controls.Add(btnOrdenarEdadDescendente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOrdenarApellidosAscendente);
            Controls.Add(btnOrdenarEdadAscendente);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstEquipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCrud";
            Text = "FormCrud";
            Load += FormCrud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEquipo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregarEquipo;
        private Button btnOrdenarEdadAscendente;
        private Button btnOrdenarApellidosAscendente;
        private Label label1;
        private Label label2;
        private Button btnOrdenarEdadDescendente;
        private Button btnOrdenarApellidosDescendente;
        private Button button1;
    }
}