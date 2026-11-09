namespace Presentacion.vistas
{
    partial class FrmCambiarContrasena
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
            txtActual = new TextBox();
            txtNueva = new TextBox();
            txtConfirmar = new TextBox();
            btnCambiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtActual
            // 
            txtActual.Location = new Point(302, 176);
            txtActual.Name = "txtActual";
            txtActual.Size = new Size(125, 27);
            txtActual.TabIndex = 0;
            // 
            // txtNueva
            // 
            txtNueva.Location = new Point(302, 232);
            txtNueva.Name = "txtNueva";
            txtNueva.Size = new Size(125, 27);
            txtNueva.TabIndex = 1;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(302, 289);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 2;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = SystemColors.HotTrack;
            btnCambiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiar.ForeColor = SystemColors.ButtonFace;
            btnCambiar.Location = new Point(183, 352);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(163, 34);
            btnCambiar.TabIndex = 3;
            btnCambiar.Text = "Finalizar";
            btnCambiar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(88, 176);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 4;
            label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(88, 232);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 5;
            label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(88, 289);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 6;
            label3.Text = "Confirmar Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 71);
            label5.Name = "label5";
            label5.Size = new Size(448, 62);
            label5.TabIndex = 12;
            label5.Text = "Cambiar Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Sylfaen", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(-12, -31);
            label6.Name = "label6";
            label6.Size = new Size(485, 156);
            label6.TabIndex = 13;
            label6.Text = "_______";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(32, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 370);
            panel1.TabIndex = 14;
            // 
            // FrmCambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(517, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiar);
            Controls.Add(txtConfirmar);
            Controls.Add(txtNueva);
            Controls.Add(txtActual);
            Controls.Add(panel1);
            Name = "FrmCambiarContrasena";
            Text = "FrmCambiarContrasena";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtActual;
        private TextBox txtNueva;
        private TextBox txtConfirmar;
        private Button btnCambiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}