using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2
{
    public class BloggingContext : DbContext
    {
        public DbSet<Drogueria> Droguerias { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Monodroga> Monodrogas { get; set; }

        public string DbPath { get; }

        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Parcial1_EF;");
    }
}
