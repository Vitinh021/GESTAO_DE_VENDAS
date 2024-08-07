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
    public partial class CadastrarProduto : Form
    {
        ProdutoRepositorio produtoRepositorio;
        CategoriaRepositorio categoriaRepositorio;
        Entidades.Produto produto;
        Entidades.Categoria categoria;

        public CadastrarProduto(Entidades.Produto produto = null, Entidades.Categoria categoria = null)
        {
            InitializeComponent();
            produtoRepositorio = new ProdutoRepositorio();
            categoriaRepositorio = new CategoriaRepositorio();
            this.produto = produto;
            this.categoria = categoria;
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbCategoria.DisplayMember = "nome";
                this.cmbCategoria.ValueMember = "id_categoria";
                this.cmbCategoria.DataSource = categoriaRepositorio.ListarCategorias();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao carregar categoria!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (this.produto != null && this.categoria != null)
            {
                this.txtNome.Text = produto.Nome;
                this.txtPreco.Text = produto.Preco.ToString();
                this.cmbCategoria.Text = categoria.Nome;
                this.btnSalvarAlterar.Text = "Atualizar";
            }
            else
            {
                this.cmbCategoria.SelectedIndex = 0;
                this.btnSalvarAlterar.Text = "Cadastrar";
            }
        }

        private void btnSalvarAlterar_Click(object sender, EventArgs e)
        {
            Entidades.Produto produto = new Entidades.Produto
            {
                Id = (this.produto == null ? 0 : this.produto.Id),
                Nome = txtNome.Text,
                Preco = Convert.ToDecimal(txtPreco.Text)
            };

            Entidades.Categoria categoria = new Entidades.Categoria
            {
                Id = Convert.ToInt32(this.cmbCategoria.SelectedValue),
                Nome = this.cmbCategoria.Text
            };

            try
            {
                if (produto.Id == 0)
                {
                    produtoRepositorio.Salvar(produto, categoria);
                    MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    produtoRepositorio.Atualizar(produto, categoria);
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao manipular produto!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}
