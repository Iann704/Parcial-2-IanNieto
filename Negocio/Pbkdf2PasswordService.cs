using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace Negocio
{
    public class Pbkdf2PasswordService : IHashService, IVerificarHashService
    {
        private const int TamanoSalt = 16;
        private const int TamanoHash = 32;
        private const int Iteraciones = 100_000;

        public string GenerarHash(string textoPlano)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(TamanoSalt);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                textoPlano, salt, Iteraciones, HashAlgorithmName.SHA256, TamanoHash);

            // Se guarda "salt.hash" en un solo texto (ambos en Base64)
            return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public bool Verificar(string textoPlano, string hashAlmacenado)
        {
            var partes = hashAlmacenado.Split('.');
            if (partes.Length != 2)
                return false;

            byte[] salt = Convert.FromBase64String(partes[0]);
            byte[] hashEsperado = Convert.FromBase64String(partes[1]);

            byte[] hashCalculado = Rfc2898DeriveBytes.Pbkdf2(
                textoPlano, salt, Iteraciones, HashAlgorithmName.SHA256, hashEsperado.Length);

            // Comparación en tiempo constante (evita ataques de temporización)
            return CryptographicOperations.FixedTimeEquals(hashCalculado, hashEsperado);
        }

    }
}
