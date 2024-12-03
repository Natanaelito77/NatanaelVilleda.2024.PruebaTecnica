using NatanaelVilleda._2024.PruebaTecnica.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatanaelVilleda._2024.PruebaTecnica.BL
{
    public class ProductoBL
    {
        private ProductoBL productoBL = new ProductoBL();

        // Obtener lista de productos
        public List<Producto> ObtenerProductos()
        {
            return productoBL.ObtenerProductos();
        }

        // Agregar un nuevo producto
        public bool AgregarProducto(Producto producto)
        {
            // Validación de negocio: asegúrate de que el precio sea mayor a 0
            if (producto.Precio <= 0)
            {
                throw new ArgumentException("El precio del producto debe ser mayor a 0.");
            }

            // Validación de negocio: verifica que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }

            return productoBL.AgregarProducto(producto);
        }
    }
}
