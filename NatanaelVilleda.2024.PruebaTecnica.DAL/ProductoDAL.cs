using Microsoft.Data.SqlClient;
using NatanaelVilleda._2024.PruebaTecnica.EntityLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatanaelVilleda._2024.PruebaTecnica.DAL
{
    public class ProductoDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        // Obtener todos los productos
        public List<Producto> ObtenerProductos()
        {
            var productos = new List<Producto>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Productos";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id= (int)reader["Id"],
                                Nombre = reader["Nombre"].ToString(),
                                Precio = (decimal)reader["Precio"],
                                IdCategoria = (int)reader["IdCategoria"]
                            });
                        }
                    }
                }
            }

            return productos;
        }

        // Agregar un nuevo producto
        public bool AgregarProducto(Producto producto)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO Productos (Nombre, Precio, IdCategoria) VALUES (@Nombre, @Precio, @IdCategoria)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true si se agregó correctamente
                }
            }
        }
    }
}
