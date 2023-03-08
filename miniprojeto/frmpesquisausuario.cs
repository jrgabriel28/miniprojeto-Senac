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
    public partial class frmpesquisausuario : Form
    {
        string stringConexao = frmlogin.stringConexao;

        public frmpesquisausuario()
        {
            InitializeComponent();
        }

        private void frmpesquisausuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarGrideUsuarioAvancado();
        }

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
                MessageBox.Show("Erro " + ex.Message);
                //MessageBox.Show("Erro " + ex.ToString());
                Application.Exit();
            }
        }
        private void CarregarGrideUsuarioAvancado()
        {
            string sql = "select " +
                "id_usuario as 'ID'," +
                "nome_usuario as 'Nome'," +
                "login_usuario as 'Login'," +
                "cpf_usuario as 'CPF'," +
                "status_usuario as 'Status'" +
                " from usuario where nome_usuario like '%" + txt_pesquisa.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                datausuario.DataSource = ds.Tables[0];
                datausuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                datausuario.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarGrideUsuarioAvancado();
        }

        public string _codigo;

        private void datausuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = datausuario.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}