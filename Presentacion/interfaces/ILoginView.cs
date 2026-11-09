using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.interfaces
{
    public interface ILoginView
    {
        string NombreUsuario { get; }
        string Contrasena { get; }

        event EventHandler IniciarSesionClick;
        event EventHandler AbrirRegistroClick;

        void MostrarMensaje(string mensaje);
        void AbrirPrincipal(Entidades.Usuario usuario);
        void AbrirRegistro();
    }
}
