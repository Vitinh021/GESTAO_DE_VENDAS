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
    internal class VendaRepositorio
    {
        private MySqlConnection conexao;

        public VendaRepositorio() { }

        public int Salvar(Venda venda)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsVenda", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id_cliente", venda.EntCliente.Id);
                    cmd.Parameters.AddWithValue("@p_data", venda.Data);

                    var id_venda = new MySqlParameter("@p_id_venda", MySqlDbType.Int32);
                    id_venda.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(id_venda);

                    cmd.ExecuteNonQuery();

                    return (int)cmd.Parameters["@p_id_venda"].Value;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Atualizar(Venda venda)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_UpdVenda", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id_cliente", venda.EntCliente.Id);
                    cmd.Parameters.AddWithValue("@p_id_venda", venda.Id);
                    cmd.Parameters.AddWithValue("@p_data", venda.Data);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(int id_venda)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_DelVenda", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_venda", id_venda);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarVendas(int id_venda = 0, string nome_cliente = "")
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                DataTable dataTable = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("sp_ListarVendas", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_venda", (id_venda == 0 ? null : id_venda));
                    cmd.Parameters.AddWithValue("@p_nome_cliente", (nome_cliente == "" ? null : nome_cliente));
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
