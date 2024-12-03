using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatanaelVilleda._2024.PruebaTecnica.BL
{
    public class CategoriaBL
    {
        private CategoriaBL categoriaBL = new CategoriaBL();

        public bool AgregarCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public bool AgregarCategoria(EntityLayer.Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return categoriaBL.ObtenerCategorias();
        }
    }

    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string? NombreCategoria { get; set; }
    }

    
}
