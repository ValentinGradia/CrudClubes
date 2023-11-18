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
            btnGuardarFutbolistas = new Button();
            btnGuardarBasquetbolistas = new Button();
            btnDeserealizarVoleibolistas = new Button();
            btnDeserealizarBasquetbolistas = new Button();
            btnDeserealizarFutbolistas = new Button();
            btnGuardarVoleibolistas = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnEliminarBBDD = new Button();
            btnModificarBBDD = new Button();
            btnAgregarBBDD = new Button();
            groupBox3 = new GroupBox();
            btnObtenerBBDD = new Button();
            rdbVoleibolistas = new RadioButton();
            rdbFutbolistas = new RadioButton();
            rdbBasquetbolistas = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            btnAgregar.Location = new Point(12, 430);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 68);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Jugador";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            btnAgregar.MouseHover += btnAgregar_MouseHover;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 526);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 68);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Jugador";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseHover += btnModificar_MouseHover;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 625);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 68);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Jugador";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseHover += btnEliminar_MouseHover;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(854, 503);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(109, 68);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnOrdenarEdadAscendente
            // 
            btnOrdenarEdadAscendente.Location = new Point(910, 43);
            btnOrdenarEdadAscendente.Name = "btnOrdenarEdadAscendente";
            btnOrdenarEdadAscendente.Size = new Size(88, 53);
            btnOrdenarEdadAscendente.TabIndex = 5;
            btnOrdenarEdadAscendente.Text = "Ordenar por Edad";
            btnOrdenarEdadAscendente.UseVisualStyleBackColor = true;
            btnOrdenarEdadAscendente.Click += btnOrdenarEdadAscendente_Click;
            // 
            // btnOrdenarApellidosAscendente
            // 
            btnOrdenarApellidosAscendente.Location = new Point(910, 121);
            btnOrdenarApellidosAscendente.Name = "btnOrdenarApellidosAscendente";
            btnOrdenarApellidosAscendente.Size = new Size(88, 55);
            btnOrdenarApellidosAscendente.TabIndex = 6;
            btnOrdenarApellidosAscendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosAscendente.UseVisualStyleBackColor = true;
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
            btnOrdenarEdadDescendente.Location = new Point(910, 247);
            btnOrdenarEdadDescendente.Name = "btnOrdenarEdadDescendente";
            btnOrdenarEdadDescendente.Size = new Size(88, 59);
            btnOrdenarEdadDescendente.TabIndex = 9;
            btnOrdenarEdadDescendente.Text = "Ordenar por Edad";
            btnOrdenarEdadDescendente.UseVisualStyleBackColor = true;
            btnOrdenarEdadDescendente.Click += btnOrdenarEdadDescendente_Click;
            // 
            // btnOrdenarApellidosDescendente
            // 
            btnOrdenarApellidosDescendente.Location = new Point(910, 328);
            btnOrdenarApellidosDescendente.Name = "btnOrdenarApellidosDescendente";
            btnOrdenarApellidosDescendente.Size = new Size(88, 63);
            btnOrdenarApellidosDescendente.TabIndex = 10;
            btnOrdenarApellidosDescendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosDescendente.UseVisualStyleBackColor = true;
            btnOrdenarApellidosDescendente.Click += btnOrdenarApellidosDescendente_Click;
            // 
            // btnGuardarFutbolistas
            // 
            btnGuardarFutbolistas.Location = new Point(233, 22);
            btnGuardarFutbolistas.Name = "btnGuardarFutbolistas";
            btnGuardarFutbolistas.Size = new Size(98, 68);
            btnGuardarFutbolistas.TabIndex = 11;
            btnGuardarFutbolistas.Text = "Guardar Futbolistas";
            btnGuardarFutbolistas.UseVisualStyleBackColor = true;
            btnGuardarFutbolistas.Click += btnGuardarFutbolistas_Click;
            // 
            // btnGuardarBasquetbolistas
            // 
            btnGuardarBasquetbolistas.Location = new Point(22, 22);
            btnGuardarBasquetbolistas.Name = "btnGuardarBasquetbolistas";
            btnGuardarBasquetbolistas.Size = new Size(99, 68);
            btnGuardarBasquetbolistas.TabIndex = 12;
            btnGuardarBasquetbolistas.Text = "Guardar Basquetbolistas";
            btnGuardarBasquetbolistas.UseVisualStyleBackColor = true;
            btnGuardarBasquetbolistas.Click += btnGuardarBasquetbolistas_Click;
            // 
            // btnDeserealizarVoleibolistas
            // 
            btnDeserealizarVoleibolistas.Location = new Point(22, 127);
            btnDeserealizarVoleibolistas.Name = "btnDeserealizarVoleibolistas";
            btnDeserealizarVoleibolistas.Size = new Size(96, 68);
            btnDeserealizarVoleibolistas.TabIndex = 13;
            btnDeserealizarVoleibolistas.Text = "Deserealizar Voleibolistas";
            btnDeserealizarVoleibolistas.UseVisualStyleBackColor = true;
            btnDeserealizarVoleibolistas.Click += btnDeserealizarVoleibolistas_Click;
            // 
            // btnDeserealizarBasquetbolistas
            // 
            btnDeserealizarBasquetbolistas.Location = new Point(124, 127);
            btnDeserealizarBasquetbolistas.Name = "btnDeserealizarBasquetbolistas";
            btnDeserealizarBasquetbolistas.Size = new Size(99, 68);
            btnDeserealizarBasquetbolistas.TabIndex = 14;
            btnDeserealizarBasquetbolistas.Text = "Deserealizar Basquetbolistas";
            btnDeserealizarBasquetbolistas.UseVisualStyleBackColor = true;
            btnDeserealizarBasquetbolistas.Click += btnDeserealizarBasquetbolistas_Click;
            // 
            // btnDeserealizarFutbolistas
            // 
            btnDeserealizarFutbolistas.Location = new Point(233, 127);
            btnDeserealizarFutbolistas.Name = "btnDeserealizarFutbolistas";
            btnDeserealizarFutbolistas.Size = new Size(98, 68);
            btnDeserealizarFutbolistas.TabIndex = 15;
            btnDeserealizarFutbolistas.Text = "Deserealizar Futbolistas";
            btnDeserealizarFutbolistas.UseVisualStyleBackColor = true;
            btnDeserealizarFutbolistas.Click += btnDeserealizarFutbolistas_Click;
            // 
            // btnGuardarVoleibolistas
            // 
            btnGuardarVoleibolistas.Location = new Point(127, 22);
            btnGuardarVoleibolistas.Name = "btnGuardarVoleibolistas";
            btnGuardarVoleibolistas.Size = new Size(96, 68);
            btnGuardarVoleibolistas.TabIndex = 16;
            btnGuardarVoleibolistas.Text = "Guardar Voleibolistas";
            btnGuardarVoleibolistas.UseVisualStyleBackColor = true;
            btnGuardarVoleibolistas.Click += btnGuardarVoleibolistas_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarBasquetbolistas);
            groupBox1.Controls.Add(btnDeserealizarVoleibolistas);
            groupBox1.Controls.Add(btnDeserealizarBasquetbolistas);
            groupBox1.Controls.Add(btnDeserealizarFutbolistas);
            groupBox1.Controls.Add(btnGuardarVoleibolistas);
            groupBox1.Controls.Add(btnGuardarFutbolistas);
            groupBox1.Location = new Point(154, 413);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 255);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serializacion JSON";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarBBDD);
            groupBox2.Controls.Add(btnModificarBBDD);
            groupBox2.Controls.Add(btnAgregarBBDD);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(517, 413);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 294);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Base de Datos";
            // 
            // btnEliminarBBDD
            // 
            btnEliminarBBDD.Location = new Point(23, 127);
            btnEliminarBBDD.Name = "btnEliminarBBDD";
            btnEliminarBBDD.Size = new Size(95, 63);
            btnEliminarBBDD.TabIndex = 18;
            btnEliminarBBDD.Text = "Eliminar Jugador";
            btnEliminarBBDD.UseVisualStyleBackColor = true;
            btnEliminarBBDD.Click += btnEliminarBBDD_Click;
            btnEliminarBBDD.MouseHover += btnEliminarBBDD_MouseHover;
            // 
            // btnModificarBBDD
            // 
            btnModificarBBDD.Location = new Point(130, 69);
            btnModificarBBDD.Name = "btnModificarBBDD";
            btnModificarBBDD.Size = new Size(95, 68);
            btnModificarBBDD.TabIndex = 1;
            btnModificarBBDD.Text = "Modificar Jugador";
            btnModificarBBDD.UseVisualStyleBackColor = true;
            btnModificarBBDD.Click += btnModificarBBDD_Click;
            btnModificarBBDD.MouseHover += btnModificarBBDD_MouseHover;
            // 
            // btnAgregarBBDD
            // 
            btnAgregarBBDD.Location = new Point(23, 22);
            btnAgregarBBDD.Name = "btnAgregarBBDD";
            btnAgregarBBDD.Size = new Size(95, 68);
            btnAgregarBBDD.TabIndex = 0;
            btnAgregarBBDD.Text = "Guardar Jugador";
            btnAgregarBBDD.UseVisualStyleBackColor = true;
            btnAgregarBBDD.Click += btnAgregarBBDD_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnObtenerBBDD);
            groupBox3.Controls.Add(rdbVoleibolistas);
            groupBox3.Controls.Add(rdbFutbolistas);
            groupBox3.Controls.Add(rdbBasquetbolistas);
            groupBox3.Location = new Point(6, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 80);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Traer lista ";
            // 
            // btnObtenerBBDD
            // 
            btnObtenerBBDD.Location = new Point(17, 27);
            btnObtenerBBDD.Name = "btnObtenerBBDD";
            btnObtenerBBDD.Size = new Size(75, 45);
            btnObtenerBBDD.TabIndex = 18;
            btnObtenerBBDD.Text = "Obtener";
            btnObtenerBBDD.UseVisualStyleBackColor = true;
            btnObtenerBBDD.Click += btnObtenerBBDD_Click;
            // 
            // rdbVoleibolistas
            // 
            rdbVoleibolistas.AutoSize = true;
            rdbVoleibolistas.Location = new Point(141, 55);
            rdbVoleibolistas.Name = "rdbVoleibolistas";
            rdbVoleibolistas.Size = new Size(90, 19);
            rdbVoleibolistas.TabIndex = 3;
            rdbVoleibolistas.TabStop = true;
            rdbVoleibolistas.Text = "Voleibolistas";
            rdbVoleibolistas.UseVisualStyleBackColor = true;
            // 
            // rdbFutbolistas
            // 
            rdbFutbolistas.AutoSize = true;
            rdbFutbolistas.Location = new Point(149, 22);
            rdbFutbolistas.Name = "rdbFutbolistas";
            rdbFutbolistas.Size = new Size(82, 19);
            rdbFutbolistas.TabIndex = 4;
            rdbFutbolistas.TabStop = true;
            rdbFutbolistas.Text = "Futbolistas";
            rdbFutbolistas.UseVisualStyleBackColor = true;
            // 
            // rdbBasquetbolistas
            // 
            rdbBasquetbolistas.AutoSize = true;
            rdbBasquetbolistas.Location = new Point(124, 39);
            rdbBasquetbolistas.Name = "rdbBasquetbolistas";
            rdbBasquetbolistas.Size = new Size(107, 19);
            rdbBasquetbolistas.TabIndex = 2;
            rdbBasquetbolistas.TabStop = true;
            rdbBasquetbolistas.Text = "Basquetbolistas";
            rdbBasquetbolistas.UseVisualStyleBackColor = true;
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 719);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Button btnGuardarFutbolistas;
        private Button btnGuardarBasquetbolistas;
        private Button btnDeserealizarVoleibolistas;
        private Button btnDeserealizarBasquetbolistas;
        private Button btnDeserealizarFutbolistas;
        private Button btnGuardarVoleibolistas;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnModificarBBDD;
        private Button btnAgregarBBDD;
        private GroupBox groupBox3;
        private Button btnObtenerBBDD;
        private RadioButton rdbVoleibolistas;
        private RadioButton rdbFutbolistas;
        private RadioButton rdbBasquetbolistas;
        private Button btnEliminarBBDD;
    }
}