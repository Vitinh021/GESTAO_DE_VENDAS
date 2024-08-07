using ecommerce.Entidades;
using ecommerce.Forms;
using ecommerce.Forms.Categoria;
using ecommerce.Forms.Produto;
using ecommerce.Forms.Venda;
using ecommerce.Repositorios;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class TelaInicial : Form
    {

        VendaRepositorio vendaRepositorio;
        ItemVendaRepositorio itemVendaRepositorio;

        public TelaInicial()
        {
            InitializeComponent();
            vendaRepositorio = new VendaRepositorio();
            itemVendaRepositorio = new ItemVendaRepositorio();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.carregarVendas();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            new CadastrarVenda().Show();
        }

        private void gerenciarCliente_Click(object sender, EventArgs e)
        {
            new GerenciarClientes().Show();
        }

        private void gerenciarCategoria_Click(object sender, EventArgs e)
        {
            new GerenciarCategoria().Show();
        }

        private void gerenciarProduto_Click(object sender, EventArgs e)
        {
            new GerenciarProduto().Show();
        }

        private void carregarVendas(string txtFiltro = "")
        {
            try
            {
                this.gridVendas.DataSource = vendaRepositorio.ListarVendas(nome_cliente: txtFiltro);
                this.gridVendas.Columns["id_venda"].DisplayIndex = 0;
                this.gridVendas.Columns["total"].DisplayIndex = 1;
                this.gridVendas.Columns["nome_cliente"].DisplayIndex = 2;
                this.gridVendas.Columns["data_venda"].DisplayIndex = 3;
                this.gridVendas.Columns["editar"].DisplayIndex = 4;
                this.gridVendas.Columns["remover"].DisplayIndex = 5;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao carregar venda!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void gridVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Entidades.Cliente cliente = new Entidades.Cliente();
                cliente.Nome = (gridVendas.Rows[e.RowIndex].Cells["nome_cliente"].Value).ToString();
                cliente.CPF = (gridVendas.Rows[e.RowIndex].Cells["cpf"].Value).ToString();
                cliente.Telefone = (gridVendas.Rows[e.RowIndex].Cells["telefone"].Value).ToString();

                Entidades.Endereco endereco = new Entidades.Endereco();
                endereco.Rua = (gridVendas.Rows[e.RowIndex].Cells["rua"].Value).ToString();
                endereco.Bairro = (gridVendas.Rows[e.RowIndex].Cells["bairro"].Value).ToString();
                endereco.Cidade = (gridVendas.Rows[e.RowIndex].Cells["cidade"].Value).ToString();
                endereco.CEP = (gridVendas.Rows[e.RowIndex].Cells["cep"].Value).ToString();
                endereco.Estado = (gridVendas.Rows[e.RowIndex].Cells["estado"].Value).ToString();
                endereco.Numero = (gridVendas.Rows[e.RowIndex].Cells["numero"].Value).ToString();

                CadastrarCliente cadastrarCliente = new CadastrarCliente(cliente, endereco);
                cadastrarCliente.txtNome.Enabled = false;
                cadastrarCliente.txtCPF.Enabled = false;
                cadastrarCliente.txtTelefone.Enabled = false;
                cadastrarCliente.txtRua.Enabled = false;
                cadastrarCliente.txtBairro.Enabled = false;
                cadastrarCliente.txtCidade.Enabled = false;
                cadastrarCliente.txtCEP.Enabled = false;
                cadastrarCliente.cmbUF.Enabled = false;
                cadastrarCliente.txtNumero.Enabled = false;
                cadastrarCliente.btnSalvarAlterar.Visible = false;
                cadastrarCliente.Show();
            }
            else if (e.ColumnIndex == 0)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = (gridVendas.Rows[e.RowIndex].Cells["nome_cliente"].Value).ToString();

                Venda venda = new Venda();
                venda.Id = Convert.ToInt32(gridVendas.Rows[e.RowIndex].Cells["id_venda"].Value);
                venda.EntCliente = cliente;

                CadastrarVenda cadastrarForm = new CadastrarVenda(venda);
                cadastrarForm.FormClosed += (s, args) => this.carregarVendas();
                cadastrarForm.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                try {
                    int id_venda = Convert.ToInt32(gridVendas.Rows[e.RowIndex].Cells["id_venda"].Value);
                    itemVendaRepositorio.Deletar(id_venda: id_venda);
                    vendaRepositorio.Deletar(id_venda);
                    MessageBox.Show("Venda deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Falha ao deletar venda!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.carregarVendas();
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarVendas(this.txtFiltro.Text);
            //this.gridVendas.DataSource = vendaRepositorio.ListarVendas(nome_cliente: this.txtFiltro.Text);

        }
    }
}
