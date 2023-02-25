using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N8_miniprojeto
{
    public partial class mdicentral : Form
    {
        private int childFormNumber = 0;

        public mdicentral()
        {
            InitializeComponent();
        }


        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategoria frmc = new frmcategoria();
            frmc.MdiParent = this;
            frmc.Show();

        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmminiprojeto frm = new frmminiprojeto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmproduto frmp = new frmproduto();
            frmp.MdiParent = this;
            frmp.Show();
        }
    }
}
