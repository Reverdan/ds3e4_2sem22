using Biblioteca.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL
{
    public class BibliotecaContext : DbContext
    {
        public static String connectionString = "Data Source=DESKTOP-R3H4MMJ\\SQLEXPRESS;" +
            "Initial Catalog=Biblioteca;" +
            "User ID=sa;" +
            "Password=rever";
        //public static DbContextOptions<BibliotecaContext> options = new DbContextOptionsBuilder<BibliotecaContext>()
        //        .UseSqlServer(new SqlConnection(connectionString))
        //        .Options;

        //protected BibliotecaContext() : base(options)
        //{
        //}

        public DbSet<Livro> LivroBD { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer();
        }
    }
}
