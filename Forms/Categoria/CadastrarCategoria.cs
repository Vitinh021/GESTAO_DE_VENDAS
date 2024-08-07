using ecommerce.Entidades;
using ecommerce.Repositorios;
using MySqlX.XDevAPI;
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
    public partial class CadastrarCategoria : Form
    {

        private CategoriaRepositorio categoriaRepositorio;
        public Entidades.Categoria categoria;

        public CadastrarCategoria(Entidades.Categoria categoria = null)
        {
            InitializeComponent();
            categoriaRepositorio = new CategoriaRepositorio();
            this.categoria = categoria;
        }

        private void btnSalvarAlterar_Click(object sender, EventArgs e)
        {

            Entidades.Categoria categoria = new Entidades.Categoria
            {
                Id = (this.categoria == null ? 0 : this.categoria.Id),
                Nome = txtNome.Text
            };

            try
            {
                if (categoria.Id == 0)
                {
                    categoriaRepositorio.Salvar(categoria);
                    MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    categoriaRepositorio.Atualizar(categoria);
                    MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao manipular categoria!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }

        private void CadastrarCategoria_Load(object sender, EventArgs e)
        {
            if (this.categoria != null)
            {
                this.txtNome.Text = categoria.Nome;
                this.btnSalvarAlterar.Text = "Atualizar";
            }
            else
            {
                this.btnSalvarAlterar.Text = "Cadastrar";
            }
        }
    }
}
