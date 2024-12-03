using Microsoft.AspNetCore.Mvc;
using NatanaelVilleda._2024.PruebaTecnica.BL;
using NatanaelVilleda._2024.PruebaTecnica.EntityLayer;

namespace NatanaelVilleda._2024.PruebaTecnica.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CategoriaBL categoriaBL;

        // Constructor
        public CategoriaController()
        {
            categoriaBL = new CategoriaBL();
        }

        // Acción para listar categorías
        [HttpGet]
        public IActionResult Index()
        {
            var categorias = categoriaBL.ObtenerCategorias();
            return View(categorias);


        }


        // Acción para mostrar el formulario para crear una nueva categoría
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        // Acción para procesar el formulario y agregar una nueva categoría
        [HttpPost]
        public IActionResult Crear(EntityLayer.Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                var resultado = categoriaBL.AgregarCategoria(categoria);

                if (resultado)
                {
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "No se pudo agregar la categoría.");
            }

            return View(categoria);
        }
    }
}

