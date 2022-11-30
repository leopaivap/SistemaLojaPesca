using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JausinPescas
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
           
            listaCategorias();
            listaMarcas();
            listaFornecedores();
            
        }

        void limpaCampos()
        {
            txtNomeProduto.Text = "";
            txtDataValidade.Text = "";
            txtPrecoCusto.Text = "";
            txtQtdEstoque.Text = "";
            txtPrecoVenda.Text = "";
            cbCategoria.Text = "";
            cbFornecedor.Text = "";
            cbMarca.Text = "";
            rtxtObsProduto.Text = "";
            txtNomeProduto.Focus();
        }

        private void lblNomeProduto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconConfirmaCadastro_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNomeProduto.Text;
            p.QntdEstoque = Convert.ToInt32(txtQtdEstoque.Text);
            p.PrecoCusto = Convert.ToDouble(txtPrecoCusto.Text);
            p.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
            p.DataValidade = Convert.ToDateTime(txtDataValidade.Text);
            p.Categoria_codCategoria1 = Convert.ToInt32(cbCategoria.SelectedValue.ToString());
            p.Marca_codMarca1 = Convert.ToInt32(cbMarca.SelectedValue.ToString());
            p.Fornecedor_codFornecedor1 = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());
            p.ObsProduto = rtxtObsProduto.Text;

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereProduto(p);
            if (retorno)
            {
                limpaCampos();
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
                lblmsgerro.Text = conecta.mensagem;


        }
        void listaCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cbCategoria.DataSource = tabelaDados;
            cbCategoria.DisplayMember = "Tipo";
            cbCategoria.ValueMember = "codCategoria";

            lblmsgerro.Text = con.mensagem;
 
        }

        void listaMarcas()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaMarcas();
            cbMarca.DataSource = tabelaDados;
            cbMarca.DisplayMember = "nomeMarca";
            cbMarca.ValueMember = "codMarca";

            lblmsgerro.Text = con.mensagem;
        }

        void listaFornecedores()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaFornecedores();
            cbFornecedor.DataSource = tabelaDados;
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "codFornecedor";

            lblmsgerro.Text = con.mensagem;
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            cbCategoria.Text = "";
            cbMarca.Text = " ";
            cbFornecedor.Text = " ";
        }
    }
}
