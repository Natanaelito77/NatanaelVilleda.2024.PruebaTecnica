using Microsoft.EntityFrameworkCore;
using NatanaelVilleda._2024.PruebaTecnica.BL;
using NatanaelVilleda._2024.PruebaTecnica.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Categoria = NatanaelVilleda._2024.PruebaTecnica.BL.Categoria;

namespace NatanaelVilleda._2024.PruebaTecnica.DAL
{
    public class ComunDb : DbContext
    {
        private readonly string _dbConnectionString = "Data Source=DESKTOP-508GN44\\SQLEXPRESS;Initial Caatalog=PruebaTecnica;Integrate Security=True;TrustServerCertificate=True;";

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
