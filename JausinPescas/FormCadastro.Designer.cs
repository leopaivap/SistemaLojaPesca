namespace JausinPescas
{
    partial class FormCadastro
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
            this.components = new System.ComponentModel.Container();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.lblObsProduto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtDataValidade = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rtxtObsProduto = new System.Windows.Forms.RichTextBox();
            this.iconConfirmaCadastro = new FontAwesome.Sharp.IconButton();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblNomeProduto.Location = new System.Drawing.Point(102, 76);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(85, 31);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome:";
            this.lblNomeProduto.Click += new System.EventHandler(this.lblNomeProduto_Click);
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQtdEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblQtdEstoque.Location = new System.Drawing.Point(102, 127);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(151, 31);
            this.lblQtdEstoque.TabIndex = 1;
            this.lblQtdEstoque.Text = "Qtd Estoque:";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblPrecoCusto.Location = new System.Drawing.Point(102, 180);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(147, 31);
            this.lblPrecoCusto.TabIndex = 2;
            this.lblPrecoCusto.Text = "Preço Custo:";
            this.lblPrecoCusto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblPrecoVenda.Location = new System.Drawing.Point(102, 236);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(152, 31);
            this.lblPrecoVenda.TabIndex = 3;
            this.lblPrecoVenda.Text = "Preço Venda:";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblDataValidade.Location = new System.Drawing.Point(102, 291);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(199, 31);
            this.lblDataValidade.TabIndex = 4;
            this.lblDataValidade.Text = "Data de Validade:";
            // 
            // lblObsProduto
            // 
            this.lblObsProduto.AutoSize = true;
            this.lblObsProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObsProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblObsProduto.Location = new System.Drawing.Point(102, 498);
            this.lblObsProduto.Name = "lblObsProduto";
            this.lblObsProduto.Size = new System.Drawing.Size(155, 31);
            this.lblObsProduto.TabIndex = 5;
            this.lblObsProduto.Text = "Obs Produto:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblMarca.Location = new System.Drawing.Point(102, 395);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(86, 31);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblCategoria.Location = new System.Drawing.Point(102, 343);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(123, 31);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblFornecedor.Location = new System.Drawing.Point(102, 448);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(142, 31);
            this.lblFornecedor.TabIndex = 8;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNomeProduto.Location = new System.Drawing.Point(301, 80);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(425, 27);
            this.txtNomeProduto.TabIndex = 9;
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtQtdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdEstoque.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtQtdEstoque.Location = new System.Drawing.Point(301, 133);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(233, 27);
            this.txtQtdEstoque.TabIndex = 10;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoCusto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrecoCusto.Location = new System.Drawing.Point(301, 186);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(233, 27);
            this.txtPrecoCusto.TabIndex = 11;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoVenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrecoVenda.Location = new System.Drawing.Point(301, 242);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(233, 27);
            this.txtPrecoVenda.TabIndex = 12;
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtDataValidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataValidade.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDataValidade.Location = new System.Drawing.Point(301, 297);
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(425, 27);
            this.txtDataValidade.TabIndex = 13;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.cbCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(301, 349);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(425, 28);
            this.cbCategoria.TabIndex = 14;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.cbMarca.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(301, 401);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(425, 28);
            this.cbMarca.TabIndex = 15;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.cbFornecedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(301, 454);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(425, 28);
            this.cbFornecedor.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtxtObsProduto
            // 
            this.rtxtObsProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.rtxtObsProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtObsProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtxtObsProduto.Location = new System.Drawing.Point(301, 504);
            this.rtxtObsProduto.Name = "rtxtObsProduto";
            this.rtxtObsProduto.Size = new System.Drawing.Size(425, 120);
            this.rtxtObsProduto.TabIndex = 18;
            this.rtxtObsProduto.Text = "";
            // 
            // iconConfirmaCadastro
            // 
            this.iconConfirmaCadastro.AutoSize = true;
            this.iconConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconConfirmaCadastro.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconConfirmaCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconConfirmaCadastro.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconConfirmaCadastro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconConfirmaCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconConfirmaCadastro.Location = new System.Drawing.Point(256, 657);
            this.iconConfirmaCadastro.Name = "iconConfirmaCadastro";
            this.iconConfirmaCadastro.Size = new System.Drawing.Size(278, 72);
            this.iconConfirmaCadastro.TabIndex = 19;
            this.iconConfirmaCadastro.Text = "Confirmar";
            this.iconConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconConfirmaCadastro.UseVisualStyleBackColor = true;
            this.iconConfirmaCadastro.Click += new System.EventHandler(this.iconConfirmaCadastro_Click);
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerro.Location = new System.Drawing.Point(460, 29);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(15, 20);
            this.lblmsgerro.TabIndex = 20;
            this.lblmsgerro.Text = "*";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(970, 814);
            this.Controls.Add(this.lblmsgerro);
            this.Controls.Add(this.iconConfirmaCadastro);
            this.Controls.Add(this.rtxtObsProduto);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblObsProduto);
            this.Controls.Add(this.lblDataValidade);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeProduto;
        private Label lblQtdEstoque;
        private Label lblPrecoCusto;
        private Label lblPrecoVenda;
        private Label lblDataValidade;
        private Label lblObsProduto;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblFornecedor;
        private TextBox txtNomeProduto;
        private TextBox txtQtdEstoque;
        private TextBox txtPrecoCusto;
        private TextBox txtPrecoVenda;
        private TextBox txtDataValidade;
        private ComboBox cbCategoria;
        private ComboBox cbMarca;
        private ComboBox cbFornecedor;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox rtxtObsProduto;
        private FontAwesome.Sharp.IconButton iconConfirmaCadastro;
        private Label lblmsgerro;
    }
}