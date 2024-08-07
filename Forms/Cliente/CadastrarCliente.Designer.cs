namespace ecommerce.Forms
{
    partial class CadastrarCliente
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
            txtCPF = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtNumero = new TextBox();
            txtCEP = new TextBox();
            cmbUF = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnSalvarAlterar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(273, 44);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(165, 23);
            txtCPF.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 47);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(65, 44);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(165, 23);
            txtTelefone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(373, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(txtCEP);
            groupBox2.Controls.Add(cmbUF);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(392, 76);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(46, 23);
            txtNumero.TabIndex = 15;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(331, 48);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(107, 23);
            txtCEP.TabIndex = 14;
            // 
            // cmbUF
            // 
            cmbUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbUF.Location = new Point(323, 76);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(44, 23);
            cmbUF.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 79);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 12;
            label9.Text = "N°:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 80);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 11;
            label8.Text = "UF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 51);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 10;
            label7.Text = "CEP:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(65, 77);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(228, 23);
            txtCidade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 80);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 8;
            label6.Text = "Cidade:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(66, 48);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(227, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(66, 16);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(372, 23);
            txtRua.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 51);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Bairro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 19);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Rua:";
            // 
            // btnSalvarAlterar
            // 
            btnSalvarAlterar.Location = new Point(382, 221);
            btnSalvarAlterar.Name = "btnSalvarAlterar";
            btnSalvarAlterar.Size = new Size(75, 23);
            btnSalvarAlterar.TabIndex = 2;
            btnSalvarAlterar.UseVisualStyleBackColor = true;
            btnSalvarAlterar.Click += btnSalvarAlterar_Click;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 256);
            Controls.Add(btnSalvarAlterar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadastrarCliente";
            Text = "CadastrarCliente";
            Load += CadastrarCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        public TextBox txtNome;
        public TextBox txtCPF;
        public TextBox txtTelefone;
        public TextBox txtBairro;
        public TextBox txtRua;
        public TextBox txtCidade;
        public ComboBox cmbUF;
        public TextBox txtNumero;
        public TextBox txtCEP;
        public Button btnSalvarAlterar;
    }
}