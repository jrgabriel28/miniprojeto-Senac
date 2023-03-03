using System.Data;
using System.Data.SqlClient;

namespace N8_miniprojeto
{

    public partial class frmminiprojeto : Form
    {
        string stringConexao = frmlogin.stringConexao;

        public frmminiprojeto()
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_login.Text = "";
            txt_senha.Text = "";
            txt_obs.Text = "";
            mask_cpf.Text = "";
            cbo_status.SelectedIndex = -1;
        }

        private void frmminiprojeto_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }


        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into usuario " + "(" +
                         "nome_usuario," +
                         "login_usuario," +
                         "senha_usuario," +
                         "cpf_usuario," +
                         "obs_usuario," +
                         "status_usuario" +
                         ") values (" +
                         "'" + txt_nome.Text + "'," +
                         "'" + txt_login.Text + "'," +
                         "'" + txt_senha.Text + "'," +
                         "'" + mask_cpf.Text + "'," +
                         "'" + txt_obs.Text + "'," +
                         "'" + cbo_status.Text + "'" + ")";

            //Campo NOME

            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo NOME.");
                txt_nome.Text = "";
                txt_nome.Focus();
                return;
            }

            //Campo Login

            if (txt_login.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo LOGIN.");
                txt_login.Text = "";
                txt_login.Focus();
                return;
            }

            //Campo Senha

            if (txt_senha.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo SENHA.");
                txt_senha.Text = "";
                txt_senha.Focus();
                return;
            }

            //Campo CPF

            if (mask_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Erro! Preenche o campo CPF.");
                mask_cpf.Focus();
                return;
            }

            //Campo Status

            if (cbo_status.SelectedIndex == - 1)
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
                    txt_codigo.Text = leitura[0].ToString();
                    bto_codigo.PerformClick();
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

        private void bto_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete usuario where id_usuario = " + txt_codigo.Text;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            string sql = "update usuario set " +
                "nome_usuario = '" + txt_nome.Text + "'," +
                "login_usuario = '" + txt_login.Text + "'," +
                "senha_usuario = '" + txt_senha.Text + "'," +
                "cpf_usuario = '" + mask_cpf.Text + "'," +
                "obs_usuario = '" + txt_obs.Text + "'," + 
                "status_usuario = '" + cbo_status.Text + "'" +
                "where id_usuario = " + txt_codigo.Text;

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

        private void bto_codigo_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where id_usuario = " + txt_codigo.Text;

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
                    txt_nome.Text = leitura[1].ToString();
                    txt_login.Text = leitura[2].ToString();
                    txt_senha.Text = leitura[3].ToString();
                    mask_cpf.Text = leitura[4].ToString();
                    txt_obs.Text = leitura[5].ToString();
                    cbo_status.Text = leitura[6].ToString();
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
    }
}