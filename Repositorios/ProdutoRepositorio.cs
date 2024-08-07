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
    public class ProdutoRepositorio
    {
        private MySqlConnection conexao;

        public ProdutoRepositorio() { }

        public void Salvar(Produto produto, Categoria categoria)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsProduto", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_categoria", categoria.Id);
                    cmd.Parameters.AddWithValue("@p_nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@p_preco", produto.Preco);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Atualizar(Produto produto, Categoria categoria)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_UpdProduto", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_produto", produto.Id);
                    cmd.Parameters.AddWithValue("@p_id_categoria", categoria.Id);
                    cmd.Parameters.AddWithValue("@p_nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@p_preco", produto.Preco);
                    cmd.ExecuteNonQuery();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(int id_produto)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_DelProduto", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_produto", id_produto);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarProdutos(int id_produto = 0, string nome_produto = "")
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                DataTable dataTable = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("sp_ListarProdutos", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_produto", (id_produto == 0 ? null : id_produto));
                    cmd.Parameters.AddWithValue("@p_nome_produto", (nome_produto == "" ? null : nome_produto));
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
