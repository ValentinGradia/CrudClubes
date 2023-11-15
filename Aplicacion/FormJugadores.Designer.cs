namespace Aplicacion
{
    partial class FormJugadores
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
            lblInformacion = new Label();
            btnAgregarFutbolista = new Button();
            btnAgregarBasquetbolista = new Button();
            btnAgregarVoleibolista = new Button();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblInformacion.Location = new Point(33, 73);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(343, 50);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "Selecciona el tipo de jugador que quieras\r\n agregar a tu equipo";
            // 
            // btnAgregarFutbolista
            // 
            btnAgregarFutbolista.Location = new Point(33, 180);
            btnAgregarFutbolista.Name = "btnAgregarFutbolista";
            btnAgregarFutbolista.Size = new Size(92, 47);
            btnAgregarFutbolista.TabIndex = 1;
            btnAgregarFutbolista.Text = "Futbolista";
            btnAgregarFutbolista.UseVisualStyleBackColor = true;
            btnAgregarFutbolista.Click += btnAgregarFutbolista_Click;
            // 
            // btnAgregarBasquetbolista
            // 
            btnAgregarBasquetbolista.Location = new Point(146, 180);
            btnAgregarBasquetbolista.Name = "btnAgregarBasquetbolista";
            btnAgregarBasquetbolista.Size = new Size(105, 47);
            btnAgregarBasquetbolista.TabIndex = 2;
            btnAgregarBasquetbolista.Text = "Basquetbolista";
            btnAgregarBasquetbolista.UseVisualStyleBackColor = true;
            btnAgregarBasquetbolista.Click += btnAgregarBasquetbolista_Click;
            // 
            // btnAgregarVoleibolista
            // 
            btnAgregarVoleibolista.Location = new Point(273, 180);
            btnAgregarVoleibolista.Name = "btnAgregarVoleibolista";
            btnAgregarVoleibolista.Size = new Size(103, 47);
            btnAgregarVoleibolista.TabIndex = 3;
            btnAgregarVoleibolista.Text = "Voleibolista";
            btnAgregarVoleibolista.UseVisualStyleBackColor = true;
            btnAgregarVoleibolista.Click += btnAgregarVoleibolista_Click_1;
            // 
            // FormJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 268);
            Controls.Add(btnAgregarVoleibolista);
            Controls.Add(btnAgregarBasquetbolista);
            Controls.Add(btnAgregarFutbolista);
            Controls.Add(lblInformacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormJugadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormJugadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private Button btnAgregarFutbolista;
        private Button btnAgregarBasquetbolista;
        private Button btnAgregarVoleibolista;
    }
}