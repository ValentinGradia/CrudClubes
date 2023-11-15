namespace Aplicacion
{
    partial class FormHistorialUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialUsuarios));
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            resources.ApplyResources(lstUsuarios, "lstUsuarios");
            lstUsuarios.Name = "lstUsuarios";
            // 
            // FormHistorialUsuarios
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lstUsuarios);
            Name = "FormHistorialUsuarios";
            Load += FormHistorialUsuarios_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstUsuarios;
    }
}