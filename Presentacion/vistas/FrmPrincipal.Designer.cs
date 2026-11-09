namespace Presentacion.vistas
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            pnlMenu = new Panel();
            btnSalir = new Button();
            btnCambiarClave = new Button();
            btnUsuarios = new Button();
            btnMenu = new Button();
            lblUsuario = new Label();
            lblHora = new Label();
            tmrReloj = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            tmrMenu = new System.Windows.Forms.Timer(components);
            ttMenu = new ToolTip(components);
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.SteelBlue;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnCambiarClave);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Controls.Add(lblUsuario);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 553);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(0, 300);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 100);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Cerrar Sesion";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCambiarClave
            // 
            btnCambiarClave.Dock = DockStyle.Top;
            btnCambiarClave.FlatStyle = FlatStyle.Flat;
            btnCambiarClave.ForeColor = SystemColors.ControlLightLight;
            btnCambiarClave.Location = new Point(0, 200);
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.Size = new Size(250, 100);
            btnCambiarClave.TabIndex = 4;
            btnCambiarClave.Text = "Cambiar Contraseña";
            btnCambiarClave.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = SystemColors.ControlLightLight;
            btnUsuarios.Location = new Point(0, 100);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(250, 100);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(250, 100);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Bottom;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(0, 503);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(250, 50);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(416, 237);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(337, 106);
            lblHora.TabIndex = 1;
            lblHora.Text = "00:00:00";
            // 
            // tmrReloj
            // 
            tmrReloj.Enabled = true;
            tmrReloj.Interval = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(454, 128);
            label1.Name = "label1";
            label1.Size = new Size(259, 62);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(475, 200);
            label2.Name = "label2";
            label2.Size = new Size(223, 49);
            label2.TabIndex = 3;
            label2.Text = "Hora Actual:";
            // 
            // tmrMenu
            // 
            tmrMenu.Interval = 10;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHora);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Button btnUsuarios;
        private Button btnMenu;
        private Label lblHora;
        private System.Windows.Forms.Timer tmrReloj;
        private Button btnSalir;
        private Button btnCambiarClave;
        private Label lblUsuario;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer tmrMenu;
        private ToolTip ttMenu;
    }
}