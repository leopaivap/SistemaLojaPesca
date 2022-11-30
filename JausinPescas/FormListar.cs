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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        void listaProduto()
        {
            ConectaBanco con = new ConectaBanco();
            dgProduto.DataSource = con.listaProdutos();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            listaProduto();
        }


    }
}
