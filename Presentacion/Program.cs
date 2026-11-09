using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using Negocio;
using Presentacion.presentadores;
using Presentacion.vistas;

namespace Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var hash = new Pbkdf2PasswordService();
            IAutenticacionService servicio = new AutenticacionService(
                new UsuarioRepositorio(), hash, hash);

            var vista = new FrmLogin();
            _ = new LoginPresenter(vista, servicio);

            vista.AccionAbrirRegistro = () =>
            {
                var frmRegistro = new FrmRegistro();
                _ = new RegistroPresenter(frmRegistro, servicio);
                frmRegistro.ShowDialog();
            };

            vista.AccionAbrirPrincipal = usuario =>
            {
                var frmPrincipal = new FrmPrincipal();
                _ = new PrincipalPresenter(frmPrincipal, usuario);

                frmPrincipal.AccionCambiarContrasena = () =>
                {
                    var frmClave = new FrmCambiarContrasena();
                    _ = new CambiarContrasenaPresenter(frmClave, servicio, usuario.NombreUsuario);
                    frmClave.ShowDialog(frmPrincipal);
                };

                vista.Hide();
                frmPrincipal.ShowDialog();
                vista.Show();
            };

            Application.Run(vista);
        }
    }
}
