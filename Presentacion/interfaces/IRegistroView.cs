using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.interfaces
{
    public interface IRegistroView
    {
        string NombreUsuario { get; }
        string Correo { get; }
        string Contrasena { get; }
        string ConfirmarContrasena { get; }
        event EventHandler RegistrarClick;
        void MostrarMensaje(string mensaje);
        void LimpiarCampos();
        void Cerrar();

    }
}
