using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
namespace Datos
{
    public interface IUsuarioRepositorio
    {
        void Registrar(Usuario usuario);
        Usuario? ObtenerPorNombre(string nombreUsuario);
    }
}
