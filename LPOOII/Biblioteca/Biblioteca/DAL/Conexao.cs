using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL
{
    public class Conexao
    {
        SqlConnection con;
        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DLPKJNG\SQLEXPRESS;
                                    Initial Catalog=biblioteca;
                                    User ID=sa;
                                    Password=unip";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

    }
}
