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
        string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=N8_miniprojetodql;" +
            "user ID=sa;" +
            "Password=123456";

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
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
