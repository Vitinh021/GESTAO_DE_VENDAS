using ecommerce.Entidades;
using ecommerce.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce.Forms.Produto
{
    public partial class GerenciarProduto : Form
    {
        ProdutoRepositorio produtoRepositorio;

        public GerenciarProduto()
        {
            InitializeComponent();
            this.produtoRepositorio = new ProdutoRepositorio();
        }

        private void GerenciarProduto_Load(object sender, EventArgs e)
        {
            this.carregarProdutos();
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Entidades.Produto produto = new Entidades.Produto();
                produto.Id = Convert.ToInt32(gridProdutos.Rows[e.RowIndex].Cells["id_produto"].Value);
                produto.Nome = Convert.ToString(gridProdutos.Rows[e.RowIndex].Cells["nome"].Value);
                produto.Preco = Convert.ToDecimal(gridProdutos.Rows[e.RowIndex].Cells["preco"].Value);

                Entidades.Categoria categoria = new Entidades.Categoria();
                categoria.Id = Convert.ToInt32(gridProdutos.Rows[e.RowIndex].Cells["id_categoria"].Value);
                categoria.Nome = Convert.ToString(gridProdutos.Rows[e.RowIndex].Cells["nome_categoria"].Value);

                CadastrarProduto cadastrarForm = new CadastrarProduto(produto, categoria);
                cadastrarForm.FormClosed += (s, args) => this.carregarProdutos();
                cadastrarForm.Show();

            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    int id = Convert.ToInt32(gridProdutos.Rows[e.RowIndex].Cells["id_produto"].Value);
                    new ProdutoRepositorio().Deletar(id);
                    MessageBox.Show("Produto deletado com sucesso!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.carregarProdutos();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Falha ao deletar produto!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarForm = new CadastrarProduto();
            cadastrarForm.FormClosed += (s, args) => this.carregarProdutos();
            cadastrarForm.Show();
        }

        private void carregarProdutos(string txtFiltro = "")
        {
            try
            {
                this.gridProdutos.DataSource = produtoRepositorio.ListarProdutos(nome_produto: txtFiltro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao listar produtos!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarProdutos(this.txtFiltro.Text);
            //this.gridProdutos.DataSource = produtoRepositorio.ListarProdutos(nome_produto: this.txtFiltro.Text);
        }
    }
}
