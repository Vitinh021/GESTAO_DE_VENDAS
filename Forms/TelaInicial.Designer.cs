namespace ecommerce
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarProduto = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCategoria = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCliente = new ToolStripMenuItem();
            gridVendas = new DataGridView();
            id_venda = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            nome_cliente = new DataGridViewTextBoxColumn();
            data_venda = new DataGridViewTextBoxColumn();
            editar = new DataGridViewTextBoxColumn();
            remover = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            rua = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            cep = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnNovaVenda = new Button();
            groupBox2 = new GroupBox();
            txtFiltro = new TextBox();
            btnFiltrar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVendas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtoToolStripMenuItem, categoriaToolStripMenuItem, clienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(656, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarProduto });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(62, 20);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // gerenciarProduto
            // 
            gerenciarProduto.Name = "gerenciarProduto";
            gerenciarProduto.Size = new Size(124, 22);
            gerenciarProduto.Text = "Gerenciar";
            gerenciarProduto.Click += gerenciarProduto_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarCategoria });
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(70, 20);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // gerenciarCategoria
            // 
            gerenciarCategoria.Name = "gerenciarCategoria";
            gerenciarCategoria.Size = new Size(124, 22);
            gerenciarCategoria.Text = "Gerenciar";
            gerenciarCategoria.Click += gerenciarCategoria_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarCliente });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // gerenciarCliente
            // 
            gerenciarCliente.Name = "gerenciarCliente";
            gerenciarCliente.Size = new Size(124, 22);
            gerenciarCliente.Text = "Gerenciar";
            gerenciarCliente.Click += gerenciarCliente_Click;
            // 
            // gridVendas
            // 
            gridVendas.AllowUserToAddRows = false;
            gridVendas.AllowUserToDeleteRows = false;
            gridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVendas.Columns.AddRange(new DataGridViewColumn[] { id_venda, total, nome_cliente, data_venda, editar, remover, telefone, cpf, rua, bairro, cidade, cep, estado, numero });
            gridVendas.Location = new Point(6, 22);
            gridVendas.Name = "gridVendas";
            gridVendas.ReadOnly = true;
            gridVendas.Size = new Size(612, 216);
            gridVendas.TabIndex = 5;
            gridVendas.CellDoubleClick += gridVendas_CellDoubleClick;
            // 
            // id_venda
            // 
            id_venda.DataPropertyName = "id_venda";
            id_venda.HeaderText = "Venda";
            id_venda.Name = "id_venda";
            id_venda.ReadOnly = true;
            // 
            // total
            // 
            total.DataPropertyName = "total";
            total.HeaderText = "Total";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // nome_cliente
            // 
            nome_cliente.DataPropertyName = "nome_cliente";
            nome_cliente.HeaderText = "Cliente";
            nome_cliente.Name = "nome_cliente";
            nome_cliente.ReadOnly = true;
            // 
            // data_venda
            // 
            data_venda.DataPropertyName = "data_venda";
            data_venda.HeaderText = "Data";
            data_venda.Name = "data_venda";
            data_venda.ReadOnly = true;
            // 
            // editar
            // 
            editar.HeaderText = "Editar";
            editar.Name = "editar";
            editar.ReadOnly = true;
            // 
            // remover
            // 
            remover.HeaderText = "Remover";
            remover.Name = "remover";
            remover.ReadOnly = true;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Visible = false;
            // 
            // cpf
            // 
            cpf.DataPropertyName = "cpf";
            cpf.HeaderText = "cpf";
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Visible = false;
            // 
            // rua
            // 
            rua.DataPropertyName = "rua";
            rua.HeaderText = "rua";
            rua.Name = "rua";
            rua.ReadOnly = true;
            rua.Visible = false;
            // 
            // bairro
            // 
            bairro.DataPropertyName = "bairro";
            bairro.HeaderText = "bairro";
            bairro.Name = "bairro";
            bairro.ReadOnly = true;
            bairro.Visible = false;
            // 
            // cidade
            // 
            cidade.DataPropertyName = "cidade";
            cidade.HeaderText = "cidade";
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Visible = false;
            // 
            // cep
            // 
            cep.DataPropertyName = "cep";
            cep.HeaderText = "cep";
            cep.Name = "cep";
            cep.ReadOnly = true;
            cep.Visible = false;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Visible = false;
            // 
            // numero
            // 
            numero.DataPropertyName = "numero";
            numero.HeaderText = "numero";
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridVendas);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 248);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vendas";
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.Location = new Point(554, 347);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(90, 23);
            btnNovaVenda.TabIndex = 7;
            btnNovaVenda.Text = "Nova Venda";
            btnNovaVenda.UseVisualStyleBackColor = true;
            btnNovaVenda.Click += btnNovaVenda_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtFiltro);
            groupBox2.Controls.Add(btnFiltrar);
            groupBox2.Location = new Point(12, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 60);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(6, 23);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(231, 23);
            txtFiltro.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(243, 23);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 379);
            Controls.Add(groupBox2);
            Controls.Add(btnNovaVenda);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            Load += TelaInicial_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVendas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem gerenciarProduto;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem gerenciarCategoria;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem gerenciarCliente;
        private DataGridView gridVendas;
        private GroupBox groupBox1;
        private Button btnNovaVenda;
        private DataGridViewTextBoxColumn id_venda;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn nome_cliente;
        private DataGridViewTextBoxColumn data_venda;
        private DataGridViewTextBoxColumn editar;
        private DataGridViewTextBoxColumn remover;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn rua;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn cep;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn numero;
        private GroupBox groupBox2;
        private TextBox txtFiltro;
        private Button btnFiltrar;
    }
}
