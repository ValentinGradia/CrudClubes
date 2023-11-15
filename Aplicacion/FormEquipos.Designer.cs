namespace Aplicacion
{
    partial class FormEquipos
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
            lstEquipos = new ListBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblUsuario = new Label();
            lblFechaRegistro = new Label();
            btnMostrarHistorial = new Button();
            SuspendLayout();
            // 
            // lstEquipos
            // 
            lstEquipos.FormattingEnabled = true;
            lstEquipos.ItemHeight = 15;
            lstEquipos.Location = new Point(12, 40);
            lstEquipos.Name = "lstEquipos";
            lstEquipos.Size = new Size(275, 244);
            lstEquipos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(356, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 60);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar equipo nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(356, 133);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(93, 57);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar equipo";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(356, 229);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 55);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar equipo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "label1";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Location = new Point(150, 9);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(38, 15);
            lblFechaRegistro.TabIndex = 5;
            lblFechaRegistro.Text = "label2";
            // 
            // btnMostrarHistorial
            // 
            btnMostrarHistorial.Location = new Point(12, 309);
            btnMostrarHistorial.Name = "btnMostrarHistorial";
            btnMostrarHistorial.Size = new Size(97, 50);
            btnMostrarHistorial.TabIndex = 6;
            btnMostrarHistorial.Text = "Mostar historial usuarios";
            btnMostrarHistorial.UseVisualStyleBackColor = true;
            btnMostrarHistorial.Click += btnMostrarHistorial_Click;
            // 
            // FormEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 371);
            Controls.Add(btnMostrarHistorial);
            Controls.Add(lblFechaRegistro);
            Controls.Add(lblUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstEquipos);
            Name = "FormEquipos";
            Text = "FormEquipos";
            FormClosing += FormEquipos_FormClosing;
            Load += FormEquipos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEquipos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblUsuario;
        private Label lblFechaRegistro;
        private Button btnMostrarHistorial;
    }
}