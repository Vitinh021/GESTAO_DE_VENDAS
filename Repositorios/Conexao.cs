using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using Microsoft.VisualBasic.ApplicationServices;

namespace ecommerce.Repositorios
{
    public class Conexao
    {
        public static MySqlConnection AbrirConexao()
        {
            try
            {
               MySqlConnection conexao = new MySqlConnection($"Server={"localhost"};Database={"e_commerce"};User Id={"root"};Password={"root"};");
               conexao.Open();
               return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void FecharConexao(MySqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
