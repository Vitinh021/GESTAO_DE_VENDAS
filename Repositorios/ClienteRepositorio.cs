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

    internal class ClienteRepositorio
    {
        private MySqlConnection conexao;

        public ClienteRepositorio() { }

        public void Salvar(Cliente cliente, Endereco endereco)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_InsCliente", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@p_telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@p_cpf", cliente.CPF);
                    cmd.Parameters.AddWithValue("@p_rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@p_numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@p_bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@p_cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@p_estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@p_cep", endereco.CEP);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Atualizar(Cliente cliente, Endereco endereco)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_UpdCliente", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id_cliente", cliente.Id);
                    cmd.Parameters.AddWithValue("@p_nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@p_telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@p_cpf", cliente.CPF);
                    cmd.Parameters.AddWithValue("@p_rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@p_numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@p_bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@p_cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@p_estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@p_cep", endereco.CEP);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(int id_cliente)
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand("sp_DelCliente", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_cliente", id_cliente);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarClientes(int id_cliente = 0, string nome_cliente = "")
        {
            try
            {
                this.conexao = Conexao.AbrirConexao();
                DataTable dataTable = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("sp_ListarClientes", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_cliente", (id_cliente == 0 ? null : id_cliente));
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
