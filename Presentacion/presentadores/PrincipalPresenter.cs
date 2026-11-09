using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using Presentacion.interfaces;

namespace Presentacion.presentadores
{
    public class PrincipalPresenter
    {
        private readonly IPrincipalView _vista;

        public PrincipalPresenter(IPrincipalView vista, Usuario usuario)
        {
            _vista = vista;

            _vista.UsuarioActual = $"Sesión: {usuario.NombreUsuario}";
            _vista.HoraActual = DateTime.Now.ToString("HH:mm:ss");

            _vista.TickReloj += (s, e) =>
                _vista.HoraActual = DateTime.Now.ToString("HH:mm:ss");
            _vista.CerrarSesionClick += (s, e) => _vista.CerrarSesion();
            _vista.CambiarContrasenaClick += (s, e) => _vista.AbrirCambioContrasena();
        }
    }
}
