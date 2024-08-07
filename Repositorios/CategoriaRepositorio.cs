using ecommerce.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Repositorios
{
    public class CategoriaRepositorio
    {
        private MySqlConnection conexao;

        public CategoriaRepositorio() { }

        public void Salvar(Categoria categoria)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsCategoria", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_nome", categoria.Nome);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Atualizar(Categoria categoria)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_UpdCategoria", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_categoria", categoria.Id);
                    cmd.Parameters.AddWithValue("@p_nome", categoria.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(int id_categoria)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_DelCategoria", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_categoria", id_categoria);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarCategorias(int id_categoria = 0, string nome_categoria = "")
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                DataTable dataTable = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("sp_ListarCategorias", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_categoria", (id_categoria == 0 ? null : id_categoria));
                    cmd.Parameters.AddWithValue("@p_nome_categoria", (nome_categoria == "" ? null : nome_categoria));
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
