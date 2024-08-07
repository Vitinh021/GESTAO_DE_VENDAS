namespace ecommerce.Forms.Produto
{
    partial class CadastrarProduto
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
            cmbCategoria = new ComboBox();
            txtPreco = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            btnSalvarAlterar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 78);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbCategoria.Location = new Point(65, 44);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(147, 23);
            cmbCategoria.TabIndex = 14;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(269, 44);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(85, 23);
            txtPreco.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 47);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Preço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 47);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoria:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(289, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição:";
            // 
            // btnSalvarAlterar
            // 
            btnSalvarAlterar.Location = new Point(291, 93);
            btnSalvarAlterar.Name = "btnSalvarAlterar";
            btnSalvarAlterar.Size = new Size(75, 23);
            btnSalvarAlterar.TabIndex = 15;
            btnSalvarAlterar.UseVisualStyleBackColor = true;
            btnSalvarAlterar.Click += btnSalvarAlterar_Click;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 124);
            Controls.Add(btnSalvarAlterar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadastrarProduto";
            Text = "CadastrarProduto";
            Load += CadastrarProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPreco;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private ComboBox cmbCategoria;
        private Button btnSalvarAlterar;
    }
}