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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconConfirmaLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            if (con.verifica(txtUsuario.Text, txtSenha.Text) == true)
            {
                Sistema sis = new Sistema();
                this.Hide();
                sis.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Usuário ou senha incorreto(s)!" + con.mensagem);
        }

        private void iconCriaConta_Click(object sender, EventArgs e)
        {
            FormAddUsuario form = new FormAddUsuario();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
