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
        string stringConexao = frmlogin.stringConexao;

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
            CarregarComboBox();
            CarregarGideProduto();
        }

        private void CarregarComboBox()
        {
            string sql = "select id_categoria, nome_categoria from categoria";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            DataTable dt = new DataTable();
            conn.Open();


            try
            {
                leitura = cmd.ExecuteReader();
                dt.Load(leitura);

                cbo_nomecategoria.DisplayMember = "nome_categoria";
                cbo_nomecategoria.DataSource = dt;

                cbo_codigocategoria.DisplayMember = "id_categoria";
                cbo_codigocategoria.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }    

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
                         "'" + cbo_codigocategoria.Text + "'," +
                         "'" + txt_nome.Text + "'," +
                         "'" + txt_qtde.Text + "'," +
                         "'" + txt_peso.Text + "'," +
                         "'" + cbo_unidade.Text + "'," +
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

            if (cbo_unidade.Text == "")
            {
                MessageBox.Show("Erro! Preenche o campo UNIDADE.");
                cbo_unidade.SelectedIndex = -1;
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
                    CarregarGideProduto();
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
            cbo_codigocategoria.SelectedIndex = -1;
            cbo_nomecategoria.SelectedIndex = -1;
            txt_codigoproduto.Text = "";
            lbl_cadastro.Text = "";
            txt_nome.Text = "";
            txt_qtde.Text = "";
            txt_peso.Text = "";
            cbo_unidade.Text = "";
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
                "id_categoria_produto = " + cbo_codigocategoria.Text + "," +
                "nome_produto = '" + txt_nome.Text + "'," +
                "qtde_produto = " + txt_qtde.Text.Replace(",",".") + "," +
                "peso_produto = " + txt_peso.Text.Replace(",", ".") + "," +
                "unidade_produto = '" + cbo_unidade.Text + "'," +
                "valorcusto_produto = " + txt_valorcusto.Text.Replace(",", ".") + "," +
                "valorvenda_produto = " + txt_valorvenda.Text.Replace(",", ".") + "," +
                "obs_produto = '" + txt_obs.Text + "'," +
                "status_produto = '" + cbo_status.Text.Trim() + "' " +
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
                    CarregarGideProduto();
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
                    cbo_codigocategoria.Text = leitura[1].ToString();
                    txt_nome.Text = leitura[2].ToString();
                    txt_qtde.Text = leitura[3].ToString();
                    txt_peso.Text = leitura[4].ToString();
                    cbo_unidade.Text = leitura[5].ToString();
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

        private void CarregarGideProduto()
        {
            string sql = "select " +
                "id_produto as 'ID'," +
                "id_categoria_produto as 'ID do Produto'," +
                "nome_produto as 'Nome'," +
                "qtde_produto as 'Qtde'," +
                "peso_produto as 'Peso'," +
                "unidade_produto as 'Unidade'," +
                "cadastro_produto as 'Data de Cadastro'," +
                "valorcusto_produto as 'Valor de Custo'," +
                "valorvenda_produto as 'Valor de Venda'," +
                "status_produto as 'Status'" +
                " from produto where nome_produto like '%" + txt_pesquisar.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                datagridproduto.DataSource = ds.Tables[0];
                datagridproduto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                datagridproduto.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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
                    CarregarGideProduto();
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

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGideProduto();
        }

        private void datagridproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoproduto.Text = datagridproduto.CurrentRow.Cells["ID"].Value.ToString();
            bto_codigoproduto.PerformClick();
        }

        private void cbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
