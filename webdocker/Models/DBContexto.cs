using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace webdocker.Models
{
    public abstract class Crud
    {
        public abstract string pesquisar(string sql);
    }

    public class Funcoes
    {
        public static string GeraStringdeConexao()
        {
            return "Database=mysql-docker" + ";Data Source=" + "locahost" + ";User Id=" + "root" + ";Password=" + "root" + ";pooling=false";
        }
    }

    public class ManipulaBanco : Crud
    {
        public override string pesquisar(string sql)
        {
            string valor = string.Empty;
            MySqlConnection conn = new MySqlConnection(Funcoes.GeraStringdeConexao());
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = null;
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                valor = dr[0].ToString();
            }
            dr.Close();
            dr.Dispose();
            conn.Close();
            conn.Dispose();
            return valor;
        }
    }
}
