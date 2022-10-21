using Biblioteca.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntity.DAL
{
    public class BibliotecaContext : DbContext
    {
        public String connectionString = "Data Source=DESKTOP-R3H4MMJ\\SQLEXPRESS;" +
            "Initial Catalog=Biblioteca;" +
            "User ID=sa;" +
            "Password=rever";

        public DbSet<Livro> LivroBD { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer();
        }
    }
}
