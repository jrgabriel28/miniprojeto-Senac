using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N8_miniprojeto
{
    public partial class frmlogin : Form
    {
       public static string stringConexao = "" +
           "Data Source=localhost;" +
           "Initial Catalog=N8_miniprojetodql;" +
           "user ID=sa;" +
           "Password=123456";

        private void TestarConexao()
        {
            try
            {
                SqlConnection conn = new SqlConnection(stringConexao);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        public frmlogin()
        {
            InitializeComponent();
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bto_entrar_Click(object sender, EventArgs e)
        {

            string sql = "select * from usuario where " +
                         "login_usuario = '" + txt_usuario.Text + "' and " +
                         "senha_usuario = '" + txt_usuario.Text + "'";

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
                    MessageBox.Show("Seja bem vindo(a)!");
                    mdicentral frm = new mdicentral();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido");
                    txt_senha.Text = "";
                    txt_usuario.Text = "";
                    txt_usuario.Focus();
                }
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

        private void frmlogin_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
    }
}
