using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NatanaelVilleda._2024.PruebaTecnica.BL;
using Microsoft.Data.SqlClient;

namespace NatanaelVilleda._2024.PruebaTecnica.DAL
{
    public class CategoriaDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public List<Categoria> ObtenerCategorias()
        {
            var categorias = new List<Categoria>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Categorias";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(new Categoria
                            {
                                IdCategoria = (int)reader["IdCategoria"],
                                NombreCategoria = reader["NombreCategoria"].ToString()
                            });
                        }
                    }
                }
            }
            return categorias;
        }
    }


}
