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
    public partial class frmcategoria : Form
    {
        string stringConexao = frmlogin.stringConexao;

        public frmcategoria()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregadarGrideCategoria();
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_nomeP.Text = "";
            txt_descricao.Text = "";
            txt_obs.Text = "";
            cbo_status.SelectedIndex = -1;
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into categoria" + "(" +
                "nome_categoria," +
                "descricao_categoria," +
                "obs_categoria," +
                "status_categoria" +
                ") values (" +
                "'" + txt_nomeP.Text + "'," +
                "'" + txt_descricao.Text + "'," +
                "'" + txt_obs.Text + "'," +
                "'" + cbo_status.Text + "'" + ")";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();


            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados Cadastrados com sucesso!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private void bto_codigo_Click(object sender, EventArgs e)
        {
            string sql = "select * from categoria where id_categoria = " + txt_codigo.Text;

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
                    txt_codigo.Text = leitura[0].ToString();
                    txt_nomeP.Text = leitura[1].ToString();
                    txt_descricao.Text = leitura[2].ToString();
                    txt_obs.Text = leitura[3].ToString();
                    cbo_status.Text = leitura[4].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Erro, categoria não existe");
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

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            string sql = "update categoria set " +
               "nome_categoria = '" + txt_nomeP.Text + "'," +
               "descricao_categoria = '" + txt_descricao.Text + "'," +
               "obs_categoria = '" + txt_obs.Text + "'," +
               "status_categoria = '" + cbo_status.Text + "' " +
                "where id_categoria = " + txt_codigo.Text;

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

        private void CarregadarGrideCategoria()
        {
            string sql = "select " +
                "id_categoria as 'ID'," +
                "nome_categoria as 'Nome'," +
                "descricao_categoria as 'Descrição'," +
                "status_categoria as 'Status'" +
                " from categoria where nome_categoria like '%" + txt_pesquisar.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                datagridecategoria.DataSource = ds.Tables[0];
                datagridecategoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                datagridecategoria.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);


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
            string sql = "delete categoria where id_categoria = " + txt_codigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

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

        private void datagridecategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = datagridecategoria.CurrentRow.Cells["ID"].Value.ToString();
            bto_codigo.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarregadarGrideCategoria();
        }

        private void datagridecategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregadarGrideCategoria();
        }
    }   
}
