namespace ecommerce.Forms.Categoria
{
    partial class GerenciarCategoria
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
            gridCategorias = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            editar = new DataGridViewTextBoxColumn();
            remover = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).BeginInit();
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
            groupBox1.Text = "Nome";
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
            // gridCategorias
            // 
            gridCategorias.AllowUserToAddRows = false;
            gridCategorias.AllowUserToDeleteRows = false;
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategorias.Columns.AddRange(new DataGridViewColumn[] { id, nome, editar, remover });
            gridCategorias.Location = new Point(12, 78);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.ReadOnly = true;
            gridCategorias.Size = new Size(582, 216);
            gridCategorias.TabIndex = 4;
            gridCategorias.CellClick += gridCategorias_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id_categoria";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
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
            // GerenciarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 340);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox1);
            Controls.Add(gridCategorias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GerenciarCategoria";
            Text = "GerenciarCategoria";
            Load += GerenciarCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private GroupBox groupBox1;
        private TextBox txtFiltro;
        private Button btnFiltrar;
        private DataGridView gridCategorias;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn editar;
        private DataGridViewTextBoxColumn remover;
        private DataGridViewTextBoxColumn id_categoria;
    }
}