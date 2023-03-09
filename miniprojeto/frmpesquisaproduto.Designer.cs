namespace N8_miniprojeto
{
    partial class frmpesquisaproduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridproduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(12, 27);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(577, 23);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            this.txt_pesquisa.DoubleClick += new System.EventHandler(this.txt_pesquisa_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa de Produto";
            // 
            // datagridproduto
            // 
            this.datagridproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridproduto.Location = new System.Drawing.Point(12, 56);
            this.datagridproduto.Name = "datagridproduto";
            this.datagridproduto.ReadOnly = true;
            this.datagridproduto.RowTemplate.Height = 25;
            this.datagridproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridproduto.Size = new System.Drawing.Size(577, 382);
            this.datagridproduto.TabIndex = 2;
            this.datagridproduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridproduto_CellDoubleClick);
            // 
            // frmpesquisaproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.datagridproduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa);
            this.Name = "frmpesquisaproduto";
            this.Text = "Pesquisa Avançada de Produto";
            this.Load += new System.EventHandler(this.frmpesquisaproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_pesquisa;
        private Label label1;
        private DataGridView datagridproduto;
    }
}