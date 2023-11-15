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
            btnAgregar.Size = new Size(91, 68);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar jugador";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            btnAgregar.MouseHover += btnAgregar_MouseHover;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(109, 430);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(95, 68);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar jugador";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseHover += btnModificar_MouseHover;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(210, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 68);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar jugador";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseHover += btnEliminar_MouseHover;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(816, 430);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(88, 68);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnOrdenarEdadAscendente
            // 
            btnOrdenarEdadAscendente.Location = new Point(910, 43);
            btnOrdenarEdadAscendente.Name = "btnOrdenarEdadAscendente";
            btnOrdenarEdadAscendente.Size = new Size(88, 53);
            btnOrdenarEdadAscendente.TabIndex = 5;
            btnOrdenarEdadAscendente.Text = "Ordenar por edad";
            btnOrdenarEdadAscendente.UseVisualStyleBackColor = true;
            btnOrdenarEdadAscendente.Click += btnOrdenarEdadAscendente_Click;
            // 
            // btnOrdenarApellidosAscendente
            // 
            btnOrdenarApellidosAscendente.Location = new Point(910, 121);
            btnOrdenarApellidosAscendente.Name = "btnOrdenarApellidosAscendente";
            btnOrdenarApellidosAscendente.Size = new Size(88, 55);
            btnOrdenarApellidosAscendente.TabIndex = 6;
            btnOrdenarApellidosAscendente.Text = "Ordenar por apellido";
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
            btnOrdenarEdadDescendente.Text = "Ordenar por edad";
            btnOrdenarEdadDescendente.UseVisualStyleBackColor = true;
            btnOrdenarEdadDescendente.Click += btnOrdenarEdadDescendente_Click;
            // 
            // btnOrdenarApellidosDescendente
            // 
            btnOrdenarApellidosDescendente.Location = new Point(910, 328);
            btnOrdenarApellidosDescendente.Name = "btnOrdenarApellidosDescendente";
            btnOrdenarApellidosDescendente.Size = new Size(88, 63);
            btnOrdenarApellidosDescendente.TabIndex = 10;
            btnOrdenarApellidosDescendente.Text = "Ordenar por apellido";
            btnOrdenarApellidosDescendente.UseVisualStyleBackColor = true;
            btnOrdenarApellidosDescendente.Click += btnOrdenarApellidosDescendente_Click;
            // 
            // btnGuardarFutbolistas
            // 
            btnGuardarFutbolistas.Location = new Point(384, 430);
            btnGuardarFutbolistas.Name = "btnGuardarFutbolistas";
            btnGuardarFutbolistas.Size = new Size(98, 68);
            btnGuardarFutbolistas.TabIndex = 11;
            btnGuardarFutbolistas.Text = "Guardar futbolistas";
            btnGuardarFutbolistas.UseVisualStyleBackColor = true;
            btnGuardarFutbolistas.Click += btnGuardarFutbolistas_Click;
            // 
            // btnGuardarBasquetbolistas
            // 
            btnGuardarBasquetbolistas.Location = new Point(488, 430);
            btnGuardarBasquetbolistas.Name = "btnGuardarBasquetbolistas";
            btnGuardarBasquetbolistas.Size = new Size(99, 68);
            btnGuardarBasquetbolistas.TabIndex = 12;
            btnGuardarBasquetbolistas.Text = "Guardar basquetbolistas";
            btnGuardarBasquetbolistas.UseVisualStyleBackColor = true;
            btnGuardarBasquetbolistas.Click += btnGuardarBasquetbolistas_Click;
            // 
            // btnDeserealizarVoleibolistas
            // 
            btnDeserealizarVoleibolistas.Location = new Point(593, 523);
            btnDeserealizarVoleibolistas.Name = "btnDeserealizarVoleibolistas";
            btnDeserealizarVoleibolistas.Size = new Size(96, 63);
            btnDeserealizarVoleibolistas.TabIndex = 13;
            btnDeserealizarVoleibolistas.Text = "Deserealizar Voleibolistas";
            btnDeserealizarVoleibolistas.UseVisualStyleBackColor = true;
            btnDeserealizarVoleibolistas.Click += btnDeserealizarVoleibolistas_Click;
            // 
            // btnDeserealizarBasquetbolistas
            // 
            btnDeserealizarBasquetbolistas.Location = new Point(488, 523);
            btnDeserealizarBasquetbolistas.Name = "btnDeserealizarBasquetbolistas";
            btnDeserealizarBasquetbolistas.Size = new Size(99, 63);
            btnDeserealizarBasquetbolistas.TabIndex = 14;
            btnDeserealizarBasquetbolistas.Text = "Deserealizar basquetbolistas";
            btnDeserealizarBasquetbolistas.UseVisualStyleBackColor = true;
            btnDeserealizarBasquetbolistas.Click += btnDeserealizarBasquetbolistas_Click;
            // 
            // btnDeserealizarFutbolistas
            // 
            btnDeserealizarFutbolistas.Location = new Point(384, 523);
            btnDeserealizarFutbolistas.Name = "btnDeserealizarFutbolistas";
            btnDeserealizarFutbolistas.Size = new Size(98, 63);
            btnDeserealizarFutbolistas.TabIndex = 15;
            btnDeserealizarFutbolistas.Text = "Deserealizar futbolistas";
            btnDeserealizarFutbolistas.UseVisualStyleBackColor = true;
            btnDeserealizarFutbolistas.Click += btnDeserealizarFutbolistas_Click;
            // 
            // btnGuardarVoleibolistas
            // 
            btnGuardarVoleibolistas.Location = new Point(593, 430);
            btnGuardarVoleibolistas.Name = "btnGuardarVoleibolistas";
            btnGuardarVoleibolistas.Size = new Size(96, 68);
            btnGuardarVoleibolistas.TabIndex = 16;
            btnGuardarVoleibolistas.Text = "Guardar Voleibolistas";
            btnGuardarVoleibolistas.UseVisualStyleBackColor = true;
            btnGuardarVoleibolistas.Click += btnGuardarVoleibolistas_Click;
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 598);
            Controls.Add(btnGuardarVoleibolistas);
            Controls.Add(btnDeserealizarFutbolistas);
            Controls.Add(btnDeserealizarBasquetbolistas);
            Controls.Add(btnDeserealizarVoleibolistas);
            Controls.Add(btnGuardarBasquetbolistas);
            Controls.Add(btnGuardarFutbolistas);
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
            //FormClosing += FormCrud_FormClosing;
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
    }
}