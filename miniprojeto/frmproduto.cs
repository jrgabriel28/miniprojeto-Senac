using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace N8_miniprojeto
{
    public partial class frmproduto : Form
    {
        string stringConexao = "" +
           "Data Source=localhost;" +
           "Initial Catalog=N8_miniprojetodql;" +
           "user ID=sa;" +
           "Password=123456";

        public frmproduto()
        {
            InitializeComponent();
        }

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                Application.Exit();

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {

            string sql = "insert into produto " + "(" +
                         "id_categoria_produto, " +
                         "nome_produto," +
                         "qtde_produto," +
                         "peso_produto," +
                         "unidade_produto," +
                         "valorcusto_produto," +
                         "valorvenda_produto," +
                         "obs_produto," +
                         "status_produto" +
                         ") values (" +
                         "'" + txt_codigocategoria.Text + "'," +
                         "'" + txt_nome.Text + "'," +
                         "'" + txt_qtde.Text + "'," +
                         "'" + txt_peso.Text + "'," +
                         "'" + txt_unidade.Text + "'," +
                         "'" + txt_valorcusto.Text + "'," +
                         "'" + txt_valorvenda.Text + "'," +
                         "'" + txt_obs.Text + "'," +
                         "'" + cbo_status.Text + "'" +
                        ")select SCOPE_IDENTITY()";

            //Campo Nome

            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo NOME DO PRODUTO.");
                txt_nome.Text = "";
                txt_nome.Focus();
                return;
            }

            //Campo QTD

            if (txt_qtde.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo QTD.");
                txt_qtde.Text = "";
                txt_qtde.Focus();
                return;
            }

            //Campo Peso

            if (txt_peso.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo PESO.");
                txt_peso.Text = "";
                txt_peso.Focus();
                return;
            }

            //Campo Unidade

            if (txt_unidade.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo UNIDADE.");
                txt_unidade.Text = "";
                txt_unidade.Focus();
                return;
            }

            //Campo Valor Custo

            if (txt_valorcusto.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo VALOR DE CUSTO.");
                txt_valorcusto.Text = "";
                txt_valorcusto.Focus();
                return;
            }

            //Campo Valor Venda

            if (txt_valorvenda.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo VALOR DE VENDA.");
                txt_valorvenda.Text = "";
                txt_valorvenda.Focus();
                return;
            }

            //Campo Status

            if (cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Erro! Selecione um STATUS.");
                cbo_status.SelectedIndex = -1;
                return;
            }

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("Dados cadastrados com sucesso");
                    bto_limpar.PerformClick();
                    MessageBox.Show("ID Gerado - " + leitura[0].ToString());
                    txt_codigoproduto.Text = leitura[0].ToString();
                    bto_codigoproduto.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();

            }

        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_codigocategoria.Text = "";
            txt_codigoproduto.Text = "";
            lbl_cadastro.Text = "";
            txt_nome.Text = "";
            txt_qtde.Text = "";
            txt_peso.Text = "";
            txt_unidade.Text = "";
            txt_valorcusto.Text = "";
            txt_valorvenda.Text = "";
            txt_obs.Text = "";
            cbo_status.SelectedIndex = -1;
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bto_codigocategoria_Click(object sender, EventArgs e)
        {

        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            string sql = "update produto set " +
                "nome_produto = '" + txt_nome.Text + "'," +
                "qtde_produto = '" + txt_qtde.Text + "'," +
                "peso_produto = '" + txt_peso.Text + "'," +
                "unidade_produto = '" + txt_unidade.Text + "'," +
                "valorcusto_produto = '" + txt_valorcusto.Text + "'," +
                "valorvenda_produto = '" + txt_valorvenda.Text + "'," +
                "status_produto = '" + cbo_status.Text + "' " +
                "where id_produto = " + txt_codigoproduto.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bto_codigoproduto_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto = " + txt_codigoproduto.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txt_codigoproduto.Text = leitura[0].ToString();
                    txt_codigocategoria.Text = leitura[1].ToString();
                    txt_nome.Text = leitura[2].ToString();
                    txt_qtde.Text = leitura[3].ToString();
                    txt_peso.Text = leitura[4].ToString();
                    txt_unidade.Text = leitura[5].ToString();
                    lbl_cadastro.Text = leitura[6].ToString();
                    txt_valorcusto.Text = leitura[7].ToString();
                    txt_valorvenda.Text = leitura[8].ToString();
                    txt_obs.Text = leitura[9].ToString();
                    cbo_status.Text = leitura[10].ToString();
                }
                else
                {
                    MessageBox.Show("Erro, usuário não existe");
                    bto_limpar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bto_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete produto where id_produto = " + txt_codigoproduto.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            lbl_cadastro.Text = "";

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                    bto_limpar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
