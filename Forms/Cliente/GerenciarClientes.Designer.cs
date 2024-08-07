namespace ecommerce.Forms
{
    partial class GerenciarClientes
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
            gridClientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            editar = new DataGridViewTextBoxColumn();
            remover = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            rua = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            cep = new DataGridViewTextBoxColumn();
            txtFiltro = new TextBox();
            btnFiltrar = new Button();
            groupBox1 = new GroupBox();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone, cpf, editar, remover, id, rua, numero, bairro, cidade, estado, cep });
            gridClientes.Location = new Point(12, 68);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.Size = new Size(582, 216);
            gridClientes.TabIndex = 0;
            gridClientes.CellClick += gridClientes_CellClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            // 
            // cpf
            // 
            cpf.DataPropertyName = "cpf";
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
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
            // id
            // 
            id.DataPropertyName = "id_cliente";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // rua
            // 
            rua.DataPropertyName = "rua";
            rua.HeaderText = "rua";
            rua.Name = "rua";
            rua.ReadOnly = true;
            rua.Visible = false;
            // 
            // numero
            // 
            numero.DataPropertyName = "numero";
            numero.HeaderText = "numero";
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Visible = false;
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
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Visible = false;
            // 
            // cep
            // 
            cep.DataPropertyName = "cep";
            cep.HeaderText = "cep";
            cep.Name = "cep";
            cep.ReadOnly = true;
            cep.Visible = false;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 60);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nome";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(519, 290);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // GerenciarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 318);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox1);
            Controls.Add(gridClientes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GerenciarClientes";
            Text = "ListarClientes";
            Load += ListarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridClientes;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnCadastrar;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn editar;
        private DataGridViewTextBoxColumn remover;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn rua;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn cep;
        private TextBox txtFiltro;
        private Button btnFiltrar;
    }
}