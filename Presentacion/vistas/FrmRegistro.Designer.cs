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
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(306, 119);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(306, 247);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(306, 177);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 2;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(306, 307);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(231, 377);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "button1";
            btnRegistrar.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 126);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 180);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 314);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 8;
            label3.Text = "Confirmar Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 254);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(txtConfirmar);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Name = "FrmRegistro";
            Text = "FrmRegistro";
            ResumeLayout(false);
            PerformLayout();
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
    }
}