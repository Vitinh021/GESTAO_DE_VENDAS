namespace ecommerce.Forms.Categoria
{
    partial class CadastrarCategoria
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
            txtNome = new TextBox();
            label1 = new Label();
            btnSalvarAlterar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 55);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categoria";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 19);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // btnSalvarAlterar
            // 
            btnSalvarAlterar.Location = new Point(245, 73);
            btnSalvarAlterar.Name = "btnSalvarAlterar";
            btnSalvarAlterar.Size = new Size(75, 23);
            btnSalvarAlterar.TabIndex = 3;
            btnSalvarAlterar.UseVisualStyleBackColor = true;
            btnSalvarAlterar.Click += btnSalvarAlterar_Click;
            // 
            // CadastrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 105);
            Controls.Add(btnSalvarAlterar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CadastrarCategoria";
            Text = "CadastrarCategoria";
            Load += CadastrarCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label label1;
        private Button btnSalvarAlterar;
    }
}