namespace Aplicacion
{
    partial class FormClubes
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lstEquipos
            // 
            lstEquipos.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstEquipos.FormattingEnabled = true;
            lstEquipos.ItemHeight = 19;
            lstEquipos.Location = new Point(12, 40);
            lstEquipos.Name = "lstEquipos";
            lstEquipos.Size = new Size(275, 232);
            lstEquipos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.InactiveCaption;
            btnAgregar.Location = new Point(332, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 60);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar equipo nuevo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.InactiveCaption;
            btnModificar.Location = new Point(332, 136);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(93, 57);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar equipo";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.InactiveCaption;
            btnEliminar.Location = new Point(332, 229);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 55);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar equipo";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(40, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "label1";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFechaRegistro.Location = new Point(150, 9);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(39, 15);
            lblFechaRegistro.TabIndex = 5;
            lblFechaRegistro.Text = "label2";
            // 
            // btnMostrarHistorial
            // 
            btnMostrarHistorial.BackColor = SystemColors.ButtonHighlight;
            btnMostrarHistorial.Location = new Point(12, 309);
            btnMostrarHistorial.Name = "btnMostrarHistorial";
            btnMostrarHistorial.Size = new Size(97, 67);
            btnMostrarHistorial.TabIndex = 6;
            btnMostrarHistorial.Text = "Mostar historial usuarios";
            btnMostrarHistorial.UseVisualStyleBackColor = false;
            btnMostrarHistorial.Click += btnMostrarHistorial_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(431, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 60);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(431, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 60);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(431, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 60);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(225, 309);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 67);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // FormClubes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(530, 388);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrarHistorial);
            Controls.Add(lblFechaRegistro);
            Controls.Add(lblUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstEquipos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormClubes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clubes";
            FormClosing += FormEquipos_FormClosing;
            Load += FormEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}