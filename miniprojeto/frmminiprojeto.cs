using System.Data;
using System.Data.SqlClient;

namespace N8_miniprojeto
{

    public partial class frmminiprojeto : Form
    {
        string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=N8_miniprojetodql;" +
            "user ID=sa;" +
            "Password=123456";

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
            Application.Exit();
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
                cbo_status.Text = "";
                cbo_status.Focus();
                return;
            }

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

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}