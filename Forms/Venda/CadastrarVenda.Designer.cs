namespace ecommerce.Forms.Venda
{
    partial class CadastrarVenda
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
            groupBox1 = new GroupBox();
            gridVendas = new DataGridView();
            groupBox2 = new GroupBox();
            txtIdVenda = new TextBox();
            btnAddItem = new Button();
            lbObs = new Label();
            lbTotal = new Label();
            btnSalvarAlterar = new Button();
            groupBox3 = new GroupBox();
            cmbClientes = new ComboBox();
            lbtot = new GroupBox();
            id_produto = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            remover = new DataGridViewTextBoxColumn();
            id_venda = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVendas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            lbtot.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridVendas);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 248);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens da venda";
            // 
            // gridVendas
            // 
            gridVendas.AllowUserToAddRows = false;
            gridVendas.AllowUserToDeleteRows = false;
            gridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVendas.Columns.AddRange(new DataGridViewColumn[] { id_produto, nome, quantidade, preco, subtotal, remover, id_venda });
            gridVendas.Location = new Point(0, 22);
            gridVendas.Name = "gridVendas";
            gridVendas.ReadOnly = true;
            gridVendas.Size = new Size(659, 216);
            gridVendas.TabIndex = 5;
            gridVendas.CellClick += gridVendas_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdVenda);
            groupBox2.Controls.Add(btnAddItem);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 60);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cod. Produto";
            // 
            // txtIdVenda
            // 
            txtIdVenda.Location = new Point(6, 23);
            txtIdVenda.Name = "txtIdVenda";
            txtIdVenda.Size = new Size(129, 23);
            txtIdVenda.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(141, 22);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Adicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lbObs
            // 
            lbObs.AutoSize = true;
            lbObs.ForeColor = Color.Red;
            lbObs.Location = new Point(245, 22);
            lbObs.Name = "lbObs";
            lbObs.Size = new Size(433, 15);
            lbObs.TabIndex = 9;
            lbObs.Text = "OBS: Para adicionar quantidades basta informar um numero , * e o Id do produto";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(6, 22);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(60, 21);
            lbTotal.TabIndex = 10;
            lbTotal.Text = "TOTAL: ";
            // 
            // btnSalvarAlterar
            // 
            btnSalvarAlterar.Location = new Point(603, 362);
            btnSalvarAlterar.Name = "btnSalvarAlterar";
            btnSalvarAlterar.Size = new Size(75, 23);
            btnSalvarAlterar.TabIndex = 3;
            btnSalvarAlterar.UseVisualStyleBackColor = true;
            btnSalvarAlterar.Click += btnFinalizar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbClientes);
            groupBox3.Location = new Point(153, 342);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 49);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cliente";
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbClientes.Location = new Point(6, 20);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(176, 23);
            cmbClientes.TabIndex = 15;
            // 
            // lbtot
            // 
            lbtot.Controls.Add(lbTotal);
            lbtot.Location = new Point(12, 342);
            lbtot.Name = "lbtot";
            lbtot.Size = new Size(135, 49);
            lbtot.TabIndex = 12;
            lbtot.TabStop = false;
            lbtot.Text = "Total";
            // 
            // id_produto
            // 
            id_produto.DataPropertyName = "id_produto";
            id_produto.HeaderText = "ID";
            id_produto.Name = "id_produto";
            id_produto.ReadOnly = true;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Produto";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.HeaderText = "QTD";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // preco
            // 
            preco.DataPropertyName = "preco";
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // subtotal
            // 
            subtotal.DataPropertyName = "subtotal";
            subtotal.HeaderText = "Subtotal";
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            // 
            // remover
            // 
            remover.HeaderText = "Remover";
            remover.Name = "remover";
            remover.ReadOnly = true;
            // 
            // id_venda
            // 
            id_venda.DataPropertyName = "id_venda";
            id_venda.HeaderText = "id_venda";
            id_venda.Name = "id_venda";
            id_venda.ReadOnly = true;
            id_venda.Visible = false;
            // 
            // CadastrarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 397);
            Controls.Add(lbtot);
            Controls.Add(groupBox3);
            Controls.Add(btnSalvarAlterar);
            Controls.Add(lbObs);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadastrarVenda";
            Text = "CadastrarVenda";
            Load += CadastrarVenda_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridVendas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            lbtot.ResumeLayout(false);
            lbtot.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView gridVendas;
        private GroupBox groupBox2;
        private TextBox txtIdVenda;
        private Button btnAddItem;
        private Label lbObs;
        private DataGridViewTextBoxColumn nome_produto;
        private Label label1;
        private Button btnSalvarAlterar;
        private Label lbTotal;
        private GroupBox groupBox3;
        private ComboBox cmbClientes;
        private GroupBox lbtot;
        private DataGridViewTextBoxColumn id_produto;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewTextBoxColumn remover;
        private DataGridViewTextBoxColumn id_venda;
    }
}