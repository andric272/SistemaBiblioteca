using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Datos
{
    public static class ConexionBD
    {
        public static string CadenaConexion { get; } = "Server=localhost;"+
            "Database=BibliotecaBD;"+
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";

    }
}