namespace ecommerce.Forms.Produto
{
    partial class GerenciarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            groupBox1 = new GroupBox();
            txtFiltro = new TextBox();
            btnFiltrar = new Button();
            gridProdutos = new DataGridView();
            id_produto = new DataGridViewTextBoxColumn();
            id_categoria = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            nome_categoria = new DataGridViewTextBoxColumn();
            editar = new DataGridViewTextBoxColumn();
            remover = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(519, 300);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 60);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descrição";
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
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { id_produto, id_categoria, nome, preco, nome_categoria, editar, remover });
            gridProdutos.Location = new Point(12, 78);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.Size = new Size(582, 216);
            gridProdutos.TabIndex = 4;
            gridProdutos.CellClick += gridProdutos_CellClick;
            // 
            // id_produto
            // 
            id_produto.DataPropertyName = "id_produto";
            id_produto.HeaderText = "id_produto";
            id_produto.Name = "id_produto";
            id_produto.ReadOnly = true;
            id_produto.Visible = false;
            // 
            // id_categoria
            // 
            id_categoria.DataPropertyName = "id_categoria";
            id_categoria.HeaderText = "id_categoria";
            id_categoria.Name = "id_categoria";
            id_categoria.ReadOnly = true;
            id_categoria.Visible = false;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Descrição";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // preco
            // 
            preco.DataPropertyName = "preco";
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // nome_categoria
            // 
            nome_categoria.DataPropertyName = "nome_categoria";
            nome_categoria.HeaderText = "Categoria";
            nome_categoria.Name = "nome_categoria";
            nome_categoria.ReadOnly = true;
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
            // GerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 333);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox1);
            Controls.Add(gridProdutos);
            Name = "GerenciarProduto";
            Text = "GerenciarProduto";
            Load += GerenciarProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private GroupBox groupBox1;
        private TextBox txtFiltro;
        private Button btnFiltrar;
        private DataGridView gridProdutos;
        private DataGridViewTextBoxColumn id_produto;
        private DataGridViewTextBoxColumn id_categoria;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn nome_categoria;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn editar;
        private DataGridViewTextBoxColumn remover;
    }
}