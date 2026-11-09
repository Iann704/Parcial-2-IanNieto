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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.Control;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(51, 144);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 28);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(180, 148);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.HotTrack;
            btnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIniciar.ForeColor = SystemColors.ButtonHighlight;
            btnIniciar.Location = new Point(102, 326);
            btnIniciar.Margin = new Padding(1);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(151, 29);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(180, 208);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 4;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = SystemColors.Control;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(51, 204);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(110, 28);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = SystemColors.HotTrack;
            btnRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistro.ForeColor = SystemColors.ButtonHighlight;
            btnRegistro.Location = new Point(259, 326);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(126, 29);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Crear cuenta";
            btnRegistro.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 23);
            label1.Name = "label1";
            label1.Size = new Size(259, 62);
            label1.TabIndex = 8;
            label1.Text = "Bienvenido";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(lblContrasena);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(79, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 368);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(47, -48);
            label2.Name = "label2";
            label2.Size = new Size(245, 156);
            label2.TabIndex = 10;
            label2.Text = "___";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(479, 450);
            Controls.Add(btnRegistro);
            Controls.Add(btnIniciar);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnIniciar;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Button btnRegistro;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}