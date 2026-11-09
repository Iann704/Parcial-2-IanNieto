namespace Presentacion.vistas
{
    partial class FrmRegistro
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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtCorreo = new TextBox();
            txtConfirmar = new TextBox();
            btnRegistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(219, 112);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(219, 240);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(219, 170);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 2;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(219, 300);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(104, 356);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(157, 37);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Completar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(11, 111);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 5;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 165);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 6;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 299);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 8;
            label3.Text = "Confirmar Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(11, 239);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 15);
            label5.Name = "label5";
            label5.Size = new Size(210, 62);
            label5.TabIndex = 9;
            label5.Text = "Registrar";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtConfirmar);
            panel1.Location = new Point(86, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 408);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(70, -47);
            label6.Name = "label6";
            label6.Size = new Size(245, 156);
            label6.TabIndex = 11;
            label6.Text = "___";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(530, 450);
            Controls.Add(panel1);
            Name = "FrmRegistro";
            Text = "FrmRegistro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtCorreo;
        private TextBox txtConfirmar;
        private Button btnRegistrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
    }
}