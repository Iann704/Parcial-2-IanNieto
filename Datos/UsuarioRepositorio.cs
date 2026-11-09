using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Datos
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public void Registrar(Usuario usuario)
        {
            using var cn = new SqlConnection(ConexionBD.CadenaConexion);
            using var cmd = new SqlCommand("sp_RegistroUsuario", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@Nombre_U", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
            cmd.Parameters.Add("@Correo_U", SqlDbType.VarChar, 100).Value = usuario.Correo;
            cmd.Parameters.Add("@Contra_U", SqlDbType.VarChar, 500).Value = usuario.PasswordHash;

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public Usuario? ObtenerPorNombre(string nombreUsuario)
        {
            using var cn = new SqlConnection(ConexionBD.CadenaConexion);
            using var cmd = new SqlCommand("sp_BusquedaUsuario", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@Nombre_U", SqlDbType.VarChar, 50).Value = nombreUsuario;

            cn.Open();
            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Usuario
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                NombreUsuario = reader.GetString(reader.GetOrdinal("Nombre_U")),
                Correo = reader.GetString(reader.GetOrdinal("Correo_U")),
                PasswordHash = reader.GetString(reader.GetOrdinal("Contra_U"))
            };
        }
    }
}
