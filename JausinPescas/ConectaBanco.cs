using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace JausinPescas
{ 
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=lojapesca");
        public String mensagem;

        public DataTable listaCategorias()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_categorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_categorias

        public DataTable listaMarcas()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_marcas", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_marcas

        public DataTable listaFornecedores()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_fornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_fornecedores

        public bool insereProduto(Produto p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", p.Nome);
            cmd.Parameters.AddWithValue("qntdEstoque", p.QntdEstoque);
            cmd.Parameters.AddWithValue("precoCusto", p.PrecoCusto);
            cmd.Parameters.AddWithValue("precoVenda", p.PrecoVenda);
            cmd.Parameters.AddWithValue("dataValidade", p.DataValidade.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("obsProduto", p.ObsProduto);
            cmd.Parameters.AddWithValue("Categoria_codCategoria", p.Categoria_codCategoria1);
            cmd.Parameters.AddWithValue("Marca_codMarca", p.Marca_codMarca1);
            cmd.Parameters.AddWithValue("Fornecedor_codFornecedor", p.Fornecedor_codFornecedor1);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereBanda

        public DataTable listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("lista_produtos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_produtos

    }
}
