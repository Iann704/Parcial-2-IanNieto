using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentacion.interfaces;

namespace Presentacion.vistas
{
    public partial class FrmRegistro : Form, IRegistroView
    {
        public FrmRegistro()
        {
            InitializeComponent();
            btnRegistrar.Click += (s, e) => RegistrarClick?.Invoke(this, EventArgs.Empty);
        }

        public string NombreUsuario => txtUsuario.Text;
        public string Correo => txtCorreo.Text;
        public string Contrasena => txtContrasena.Text;
        public string ConfirmarContrasena => txtConfirmar.Text;

        public event EventHandler? RegistrarClick;

        public void MostrarMensaje(string mensaje) =>
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            txtConfirmar.Clear();
        }

        public void Cerrar() => Close();
    }
}
