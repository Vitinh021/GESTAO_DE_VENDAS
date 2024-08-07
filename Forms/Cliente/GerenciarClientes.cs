using ecommerce.Entidades;
using ecommerce.Repositorios;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce.Forms
{
    public partial class GerenciarClientes : Form
    {
        private ClienteRepositorio clienteRepositorio;

        public GerenciarClientes()
        {
            InitializeComponent();
            clienteRepositorio = new ClienteRepositorio();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            this.carregarClientes();
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(gridClientes.Rows[e.RowIndex].Cells["id"].Value);
                cliente.Nome = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["nome"].Value);
                cliente.Telefone = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["telefone"].Value);
                cliente.CPF = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["cpf"].Value);

                Endereco endereco = new Endereco();
                endereco.Rua = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["rua"].Value);
                endereco.Numero = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["numero"].Value);
                endereco.Bairro = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["bairro"].Value);
                endereco.Cidade = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["cidade"].Value);
                endereco.Estado = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["estado"].Value);
                endereco.CEP = Convert.ToString(gridClientes.Rows[e.RowIndex].Cells["cep"].Value);

                CadastrarCliente cadastrarForm = new CadastrarCliente(cliente, endereco);
                cadastrarForm.FormClosed += (s, args) => this.carregarClientes();
                cadastrarForm.Show();

            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    int id = Convert.ToInt32(gridClientes.Rows[e.RowIndex].Cells["id"].Value);
                    new ClienteRepositorio().Deletar(id);
                    MessageBox.Show("Deletado com sucesso!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.carregarClientes();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Falha ao deletar cliente!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarForm = new CadastrarCliente();
            cadastrarForm.FormClosed += (s, args) => this.carregarClientes();
            cadastrarForm.Show();
        }

        private void carregarClientes(string txtFiltro = "")
        {
            try
            {
                this.gridClientes.DataSource = clienteRepositorio.ListarClientes(nome_cliente: txtFiltro);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao carregar clientes!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarClientes(this.txtFiltro.Text);
            //this.gridClientes.DataSource = clienteRepositorio.ListarClientes(nome_cliente : );
        }
    }
}
