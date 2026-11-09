namespace Presentacion.vistas
{
    partial class FrmLogin
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            btnIniciar = new Button();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(111, 144);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(250, 144);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(111, 280);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(151, 29);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(250, 204);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 4;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(111, 204);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(83, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(268, 280);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(126, 29);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Crear cuenta";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(btnRegistro);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(btnIniciar);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnIniciar;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Button btnRegistro;
    }
}