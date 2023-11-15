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
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(78, 205);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 42);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(43, 137);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingrese su contraseña...";
            txtContraseña.Size = new Size(202, 23);
            txtContraseña.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(43, 84);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese su mail...";
            txtMail.Size = new Size(202, 23);
            txtMail.TabIndex = 2;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 280);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(btnAceptar);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtContraseña;
        private TextBox txtMail;
    }
}