using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
    public class AutenticacionService : IAutenticacionService
    {
        private readonly IUsuarioRepositorio _repositorio;
        private readonly IHashService _hashService;
        private readonly IVerificarHashService _verificarService;

        public AutenticacionService(
            IUsuarioRepositorio repositorio,
            IHashService hashService,
            IVerificarHashService verificarService)
        {
            _repositorio = repositorio;
            _hashService = hashService;
            _verificarService = verificarService;
        }

        public void Registrar(string nombreUsuario, string correo, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains('@'))
                throw new ArgumentException("El correo no es válido.");
            if (string.IsNullOrEmpty(contrasena) || contrasena.Length < 6)
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");

            var usuario = new Usuario
            {
                NombreUsuario = nombreUsuario.Trim(),
                Correo = correo.Trim(),
                PasswordHash = _hashService.GenerarHash(contrasena)
            };

            _repositorio.Registrar(usuario);
        }

        public Usuario? IniciarSesion(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrEmpty(contrasena))
                return null;

            var usuario = _repositorio.ObtenerPorNombre(nombreUsuario.Trim());
            if (usuario is null)
                return null;

            return _verificarService.Verificar(contrasena, usuario.PasswordHash)
                ? usuario
                : null;
        }
    }
}
