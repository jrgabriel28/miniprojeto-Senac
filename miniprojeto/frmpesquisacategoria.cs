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
    public partial class frmpesquisacategoria : Form
    {
        string stringConexao = frmlogin.stringConexao;

        public frmpesquisacategoria()
        {
            InitializeComponent();
        }

        private void TesteConexao()
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

        private void frmpesquisacategoria_Load(object sender, EventArgs e)
        {
            TesteConexao();
            CarregarGridCategoria();
        }

        private void CarregarGridCategoria()
        {
            string sql = "select " +
                "id_categoria as 'ID'," +
                "nome_categoria as 'Nome'," +
                "descricao_categoria as 'Descrição'," +
                "status_categoria as 'Status'" +
                " from categoria where nome_categoria like '%" + txt_pesquisa.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                datagridcategoria.DataSource = ds.Tables[0];
                datagridcategoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                datagridcategoria.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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
            CarregarGridCategoria();
        }

        public string _codigo;

        private void datagridcategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = datagridcategoria.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}
