using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatanaelVilleda._2024.PruebaTecnica.BL;
using NatanaelVilleda._2024.PruebaTecnica.EntityLayer;

namespace NatanaelVilleda._2024.PruebaTecnica.Controllers
{
    public class ProductoController : Controller
    {
        private ProductoBL productoBL = new ProductoBL();

        // Acción para listar productos
        public ActionResult Index()
        {
            var productos = productoBL.ObtenerProductos();
            return View(productos);
        }

        // Acción para agregar un nuevo producto
        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            if (ModelState.IsValid)
            {
                bool resultado = productoBL.AgregarProducto(producto);

                if (resultado)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(producto);
        }

    }
}
