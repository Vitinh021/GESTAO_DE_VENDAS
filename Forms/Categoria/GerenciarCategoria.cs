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

namespace ecommerce.Forms.Categoria
{
    public partial class GerenciarCategoria : Form
    {
        private CategoriaRepositorio categoriaRepositorio;

        public GerenciarCategoria()
        {
            InitializeComponent();
            categoriaRepositorio = new CategoriaRepositorio();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCategoria cadastrarForm = new CadastrarCategoria();
            cadastrarForm.FormClosed += (s, args) => this.carregarCategorias();
            cadastrarForm.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarCategorias(this.txtFiltro.Text);
            //this.gridCategorias.DataSource = categoriaRepositorio.ListarCategorias(nome_categoria: this.txtFiltro.Text);
        }

        private void carregarCategorias(string txtFiltro = "")
        {
            try
            {
                this.gridCategorias.DataSource = categoriaRepositorio.ListarCategorias(nome_categoria: txtFiltro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao carregar categorias!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void GerenciarCategoria_Load(object sender, EventArgs e)
        {
            this.carregarCategorias();
        }

        private void gridCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Entidades.Categoria categoria = new Entidades.Categoria();
                categoria.Id = Convert.ToInt32(gridCategorias.Rows[e.RowIndex].Cells["id"].Value);
                categoria.Nome = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["nome"].Value);

                CadastrarCategoria cadastrarForm = new CadastrarCategoria(categoria);
                cadastrarForm.FormClosed += (s, args) => this.carregarCategorias();
                cadastrarForm.Show();

            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    int id = Convert.ToInt32(gridCategorias.Rows[e.RowIndex].Cells["id"].Value);
                    new CategoriaRepositorio().Deletar(id);
                    MessageBox.Show("Deletado com sucesso!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.carregarCategorias();
                }
                catch (Exception ex) { 
                    if(ex.Message.Contains("Cannot delete or update a parent row: a foreign key constraint fails"))
                    {
                        MessageBox.Show("Há produtos com essa categoria, ela não pode ser deletada!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao deletar!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
