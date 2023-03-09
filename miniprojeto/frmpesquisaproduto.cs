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
    public partial class frmpesquisaproduto : Form
    {
        string stringConexao = frmlogin.stringConexao;

        public frmpesquisaproduto()
        {
            InitializeComponent();
        }

        public string _codigo;

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

        private void frmpesquisaproduto_Load(object sender, EventArgs e)
        {
            TesteConexao();
            CarregarGridProduto();

        }

        private void CarregarGridProduto()
        {
            string sql = "select " +
                "id_produto as 'ID'," +
                "id_categoria_produto as 'Codigo Categoria'," +
                "nome_produto as 'Nome'," +
                "qtde_produto as 'Qtde'," +
                "peso_produto as 'Peso'," +
                "unidade_produto as 'Unidade'," +
                "cadastro_produto as 'Cadastro'," +
                "valorcusto_produto as 'Valor de Custo'," +
                "valorvenda_produto as 'Valor de Venda'," +
                "status_produto as 'Status'" +
                " from produto where nome_produto like '%" + txt_pesquisa.Text + "%'";


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

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarGridProduto();
        }

        private void txt_pesquisa_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void datagridproduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = datagridproduto.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}
