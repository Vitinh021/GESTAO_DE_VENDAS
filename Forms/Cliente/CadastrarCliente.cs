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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ecommerce.Forms
{
    public partial class CadastrarCliente : Form
    {
        private ClienteRepositorio clienteRepositorio;
        public Cliente cliente;
        public Endereco endereco;

        public CadastrarCliente(Cliente cliente = null, Endereco endereco = null)
        {
            InitializeComponent();
            this.clienteRepositorio = new ClienteRepositorio();
            this.cliente = cliente;
            this.endereco = endereco;
        }

        private void btnSalvarAlterar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente
            {
                Id = (this.cliente == null ? 0 : this.cliente.Id),
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                CPF = txtCPF.Text,

            };

            Endereco endereco = new Endereco
            {
                Rua = txtRua.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                CEP = txtCEP.Text,
                Estado = cmbUF.Text,
                Numero = txtNumero.Text,
                EntCliente = cliente
            };

            try
            {
                if (cliente.Id == 0)
                {
                    clienteRepositorio.Salvar(cliente, endereco);
                    MessageBox.Show("Cliente salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clienteRepositorio.Atualizar(cliente, endereco);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Falha ao salvar cliente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

            if (this.cliente != null && this.endereco != null)
            {
                this.txtNome.Text = cliente.Nome;
                this.txtTelefone.Text = cliente.Telefone;
                this.txtCPF.Text = cliente.CPF;
                this.txtRua.Text = endereco.Rua;
                this.txtBairro.Text = endereco.Bairro;
                this.txtCidade.Text = endereco.Cidade;
                this.txtCEP.Text = endereco.CEP;
                this.cmbUF.Text = endereco.Estado;
                this.txtNumero.Text = endereco.Numero;
                this.btnSalvarAlterar.Text = "Atualizar";
            }
            else
            {
                this.cmbUF.SelectedIndex = 0;
                this.btnSalvarAlterar.Text = "Cadastrar";
            }
        }

    }
}
