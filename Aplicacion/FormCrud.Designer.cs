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
            btnSerealizar = new Button();
            btnDeserealizar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstEquipo
            // 
            lstEquipo.FormattingEnabled = true;
            lstEquipo.ItemHeight = 15;
            lstEquipo.Location = new Point(12, 12);
            lstEquipo.Name = "lstEquipo";
            lstEquipo.Size = new Size(892, 379);
            lstEquipo.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Location = new Point(12, 445);
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
            btnModificar.Location = new Point(153, 445);
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
            btnEliminar.Location = new Point(296, 445);
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
            btnAgregarEquipo.Location = new Point(773, 440);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(131, 89);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnOrdenarEdadAscendente
            // 
            btnOrdenarEdadAscendente.BackColor = Color.FromArgb(255, 192, 128);
            btnOrdenarEdadAscendente.Location = new Point(910, 43);
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
            btnOrdenarApellidosAscendente.Location = new Point(910, 121);
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
            label1.Location = new Point(910, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Ascendente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(910, 212);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Descendente";
            // 
            // btnOrdenarEdadDescendente
            // 
            btnOrdenarEdadDescendente.BackColor = Color.FromArgb(255, 192, 128);
            btnOrdenarEdadDescendente.Location = new Point(910, 247);
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
            btnOrdenarApellidosDescendente.Location = new Point(910, 328);
            btnOrdenarApellidosDescendente.Name = "btnOrdenarApellidosDescendente";
            btnOrdenarApellidosDescendente.Size = new Size(88, 63);
            btnOrdenarApellidosDescendente.TabIndex = 10;
            btnOrdenarApellidosDescendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosDescendente.UseVisualStyleBackColor = false;
            btnOrdenarApellidosDescendente.Click += btnOrdenarApellidosDescendente_Click;
            // 
            // btnSerealizar
            // 
            btnSerealizar.BackColor = SystemColors.InactiveCaption;
            btnSerealizar.Location = new Point(18, 43);
            btnSerealizar.Name = "btnSerealizar";
            btnSerealizar.Size = new Size(98, 68);
            btnSerealizar.TabIndex = 11;
            btnSerealizar.Text = "Serealizar jugador";
            btnSerealizar.UseVisualStyleBackColor = false;
            btnSerealizar.Click += btnSerealizar_Click;
            // 
            // btnDeserealizar
            // 
            btnDeserealizar.BackColor = SystemColors.InactiveCaption;
            btnDeserealizar.Location = new Point(103, 119);
            btnDeserealizar.Name = "btnDeserealizar";
            btnDeserealizar.Size = new Size(98, 68);
            btnDeserealizar.TabIndex = 15;
            btnDeserealizar.Text = "Deserealizar jugador";
            btnDeserealizar.UseVisualStyleBackColor = false;
            btnDeserealizar.Click += btnDeserealizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSkyBlue;
            groupBox1.Controls.Add(btnDeserealizar);
            groupBox1.Controls.Add(btnSerealizar);
            groupBox1.Location = new Point(462, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 201);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serializacion XML";
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1058, 609);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
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
        private Button btnSerealizar;
        private Button btnDeserealizar;
        private GroupBox groupBox1;
    }
}