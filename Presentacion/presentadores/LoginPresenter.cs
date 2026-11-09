    using System;
using System.Collections.Generic;
using System.Text;
using Negocio;
using Presentacion.interfaces;

namespace Presentacion.presentadores
{
    public class LoginPresenter
    {
        private readonly ILoginView _vista;
        private readonly IAutenticacionService _servicio;

        public LoginPresenter(ILoginView vista, IAutenticacionService servicio)
        {
            _vista = vista;
            _servicio = servicio;

            _vista.IniciarSesionClick += OnIniciarSesion;
            _vista.AbrirRegistroClick += (s, e) => _vista.AbrirRegistro();
        }

        private void OnIniciarSesion(object? sender, EventArgs e)
        {
            try
            {
                var usuario = _servicio.IniciarSesion(_vista.NombreUsuario, _vista.Contrasena);

                if (usuario is null)
                    _vista.MostrarMensaje("Usuario o contraseña incorrectos.");
                else
                    _vista.AbrirPrincipal(usuario);
            }
            catch (Exception)
            {
                _vista.MostrarMensaje("No se pudo conectar con la base de datos.");
            }
        }
    }
}
