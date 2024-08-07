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
    internal class ItemVendaRepositorio
    {

        private MySqlConnection conexao;

        public ItemVendaRepositorio() { }

        public void Salvar(ItemVenda item)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsItemVenda", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id_produto", item.EntProduto.Id);
                    cmd.Parameters.AddWithValue("@p_id_venda", item.EntVenda.Id);
                    cmd.Parameters.AddWithValue("@p_quantidade", item.Quantidade);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Deletar(int id_item = 0, int id_venda = 0)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_DelItemVenda", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_item", (id_item == 0 ? null : id_item));
                    cmd.Parameters.AddWithValue("@p_id_venda",(id_venda == 0 ? null : id_venda));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarItens(int id_venda = 0)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                DataTable dataTable = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("sp_ListarItens", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_venda", (id_venda == 0 ? null : id_venda));
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
