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
            SuspendLayout();
            // 
            // txtActual
            // 
            txtActual.Location = new Point(277, 117);
            txtActual.Name = "txtActual";
            txtActual.Size = new Size(125, 27);
            txtActual.TabIndex = 0;
            // 
            // txtNueva
            // 
            txtNueva.Location = new Point(277, 202);
            txtNueva.Name = "txtNueva";
            txtNueva.Size = new Size(125, 27);
            txtNueva.TabIndex = 1;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(277, 287);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 2;
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(232, 354);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(94, 29);
            btnCambiar.TabIndex = 3;
            btnCambiar.Text = "Finalizar";
            btnCambiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 124);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 4;
            label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 209);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 294);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirmar Contraseña";
            // 
            // FrmCambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiar);
            Controls.Add(txtConfirmar);
            Controls.Add(txtNueva);
            Controls.Add(txtActual);
            Name = "FrmCambiarContrasena";
            Text = "FrmCambiarContrasena";
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
    }
}