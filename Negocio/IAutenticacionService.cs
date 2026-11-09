using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public interface IAutenticacionService
    {
        void Registrar(string nombreUsuario, string correo, string contrasena);
        Usuario? IniciarSesion(string nombreUsuario, string contrasena);
    }
}
