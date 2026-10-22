using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using Microsoft.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class LibroDatos
    {
        public List<Libro> ListarLibros()
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection conexion = new SqlConnection(ConexionBD.CadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand("dbo.usp_listarLibros", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libro libro = new Libro
                            {
                                IdLibro = Convert.ToInt32(reader["IdLibro"]),
                                Titulo = reader["Titulo"].ToString() ?? "",
                                Autor = reader["Autor"].ToString() ?? "",
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Stock = Convert.ToInt32(reader["Stock"])
                            };
                            lista.Add(libro);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
