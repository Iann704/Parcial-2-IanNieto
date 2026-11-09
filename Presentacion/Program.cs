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

            Application.Run(vista);
        }
    }
}
