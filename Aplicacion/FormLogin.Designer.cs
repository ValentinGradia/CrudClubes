namespace Aplicacion
{
    partial class FormLogin
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
            txtContraseña = new TextBox();
            txtMail = new TextBox();
            cbxContraseña = new CheckBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.InactiveCaption;
            btnAceptar.Location = new Point(84, 246);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 42);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(43, 188);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingrese su contraseña...";
            txtContraseña.Size = new Size(202, 23);
            txtContraseña.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(43, 113);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese su mail...";
            txtMail.Size = new Size(202, 23);
            txtMail.TabIndex = 2;
            // 
            // cbxContraseña
            // 
            cbxContraseña.AutoSize = true;
            cbxContraseña.Location = new Point(268, 192);
            cbxContraseña.Name = "cbxContraseña";
            cbxContraseña.Size = new Size(15, 14);
            cbxContraseña.TabIndex = 3;
            cbxContraseña.UseVisualStyleBackColor = true;
            cbxContraseña.CheckedChanged += cbxContraseña_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 66);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 95);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 168);
            label2.Name = "label2";
            label2.Size = new Size(77, 16);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(328, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(267, 301);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(597, 300);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(cbxContraseña);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicacion";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtContraseña;
        private TextBox txtMail;
        private CheckBox cbxContraseña;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}