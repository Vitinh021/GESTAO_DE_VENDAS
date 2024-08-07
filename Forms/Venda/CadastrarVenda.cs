using ecommerce.Entidades;
using ecommerce.Repositorios;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ecommerce.Forms.Venda
{
    public partial class CadastrarVenda : Form
    {
        ProdutoRepositorio produtoRepositorio;
        ClienteRepositorio clienteRepositorio;
        VendaRepositorio vendaRepositorio;
        ItemVendaRepositorio itemVendaRepositorio;
        Entidades.Venda venda;

        public CadastrarVenda(Entidades.Venda venda = null)
        {
            InitializeComponent();
            produtoRepositorio = new ProdutoRepositorio();
            clienteRepositorio = new ClienteRepositorio();
            vendaRepositorio = new VendaRepositorio();
            itemVendaRepositorio = new ItemVendaRepositorio();
            this.venda = venda;
        }

        private void CadastrarVenda_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbClientes.DisplayMember = "nome";
                this.cmbClientes.ValueMember = "id_cliente";
                this.cmbClientes.DataSource = clienteRepositorio.ListarClientes();

                if (this.venda != null)
                {
                    this.cmbClientes.Text = venda.EntCliente.Nome;
                    DataTable data = new DataTable();
                    data = itemVendaRepositorio.ListarItens(venda.Id);


                    foreach (DataRow row in data.Rows)
                    {
                        int id = Convert.ToInt32(row["id_produto"]);
                        string nome = row["nome"].ToString();
                        double preco = (Convert.ToDouble(row["preco"]));
                        int qtd = (Convert.ToInt32(row["quantidade"]));
                        double sub = (Convert.ToDouble(row["subtotal"]));

                        this.gridVendas.Rows.Add(id, nome, qtd, preco.ToString("F2"), sub.ToString("F2"));
                    }

                    this.gridVendas.Columns["id_produto"].DisplayIndex = 0;
                    this.gridVendas.Columns["nome"].DisplayIndex = 1;
                    this.gridVendas.Columns["quantidade"].DisplayIndex = 2;
                    this.gridVendas.Columns["preco"].DisplayIndex = 3;
                    this.gridVendas.Columns["subtotal"].DisplayIndex = 4;
                    this.gridVendas.Columns["remover"].DisplayIndex = 5;

                    this.calcularTotal();
                    this.btnSalvarAlterar.Text = "Atualizar";
                }
                else
                {
                    this.btnSalvarAlterar.Text = "Finalizar";
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro ao abrir formulario!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] partes = this.txtIdVenda.Text.Split('*');
                int qtd = 1;
                int id_prod = Convert.ToInt32(partes[0]);

                if (partes.Length == 2)
                {
                    qtd = Convert.ToInt32(partes[0]);
                    id_prod = Convert.ToInt32(partes[1]);
                }

                DataTable data = new DataTable();
                data = produtoRepositorio.ListarProdutos(id_produto: id_prod);

                foreach (DataRow row in data.Rows)
                {
                    int id = Convert.ToInt32(row["id_produto"]);
                    string nome = row["nome"].ToString();
                    double preco = (Convert.ToDouble(row["preco"]));
                    double sub = ((Convert.ToDouble(row["preco"])) * qtd);

                    gridVendas.Rows.Add(id, nome, qtd, preco.ToString("F2"), sub.ToString("F2"));

                }
                this.calcularTotal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao adicionar item!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcularTotal()
        {
            double total = 0;
            this.lbTotal.Text = "0";
            foreach (DataGridViewRow row in gridVendas.Rows)
            {
                total = total + Convert.ToDouble(row.Cells["subtotal"].Value);
                this.lbTotal.Text = $"{total.ToString("F2")}";
            }
        }

        private void gridVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0 && e.RowIndex < gridVendas.Rows.Count)
                {
                    gridVendas.Rows.RemoveAt(e.RowIndex);
                    this.calcularTotal();
                }

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            Entidades.Cliente cliente = new Entidades.Cliente
            {
                Id = Convert.ToInt32(this.cmbClientes.SelectedValue) 
            };

            Entidades.Venda entVenda = new Entidades.Venda
            {
                EntCliente = cliente
            };
            try
            {

                if (this.venda.Id == 0)
                {
                    entVenda.Id = vendaRepositorio.Salvar(entVenda);
                }
                else
                {
                    this.venda.EntCliente.Id = cliente.Id;
                    itemVendaRepositorio.Deletar(id_venda: this.venda.Id);
                }

                Entidades.Produto produto = new Entidades.Produto();
                Entidades.ItemVenda item = new Entidades.ItemVenda();

                foreach (DataGridViewRow row in gridVendas.Rows)
                {
                    produto.Id = Convert.ToInt32(row.Cells["id_produto"].Value);

                    item.Quantidade = Convert.ToInt32(row.Cells["quantidade"].Value);
                    item.EntProduto = produto;
                    item.EntVenda = (this.venda.Id == 0 ? entVenda : this.venda);

                    itemVendaRepositorio.Salvar(item);
                }

                if (this.venda.Id == 0)
                {
                    MessageBox.Show("Venda salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultado = MessageBox.Show("Deseja realizar uma nova venda?", "Nova Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.txtIdVenda.Text = "";
                        this.gridVendas.Rows.Clear();
                        this.cmbClientes.SelectedIndex = 0;
                        this.lbTotal.Text = "0";
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    vendaRepositorio.Atualizar(this.venda);
                    MessageBox.Show("Venda atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao manipular venda!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}
