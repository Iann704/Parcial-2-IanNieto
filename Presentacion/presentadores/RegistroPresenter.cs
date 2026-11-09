using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Negocio;
using Presentacion.interfaces;

namespace Presentacion.presentadores
{
    public class RegistroPresenter
    {
        private readonly IRegistroView _vista;
        private readonly IAutenticacionService _servicio;

        public RegistroPresenter(IRegistroView vista, IAutenticacionService servicio)
        {
            _vista = vista;
            _servicio = servicio;

            _vista.RegistrarClick += OnRegistrar;
        }

        private void OnRegistrar(object? sender, EventArgs e)
        {
            if (_vista.Contrasena != _vista.ConfirmarContrasena)
            {
                _vista.MostrarMensaje("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                _servicio.Registrar(_vista.NombreUsuario, _vista.Correo, _vista.Contrasena);
                _vista.MostrarMensaje("Usuario registrado correctamente.");
                _vista.LimpiarCampos();
                _vista.Cerrar();
            }
            catch (ArgumentException ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
            catch (SqlException ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }
    }
}
