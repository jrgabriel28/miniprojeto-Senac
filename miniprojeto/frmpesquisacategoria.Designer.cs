namespace N8_miniprojeto
{
    partial class frmpesquisacategoria
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
            this.datagridcategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(12, 25);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(577, 23);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar Categoria";
            // 
            // datagridcategoria
            // 
            this.datagridcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcategoria.Location = new System.Drawing.Point(12, 54);
            this.datagridcategoria.Name = "datagridcategoria";
            this.datagridcategoria.ReadOnly = true;
            this.datagridcategoria.RowTemplate.Height = 25;
            this.datagridcategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridcategoria.Size = new System.Drawing.Size(577, 384);
            this.datagridcategoria.TabIndex = 2;
            this.datagridcategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcategoria_CellDoubleClick);
            // 
            // frmpesquisacategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.datagridcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa);
            this.Name = "frmpesquisacategoria";
            this.Text = "Pesquisa Avançada de Categoria";
            this.Load += new System.EventHandler(this.frmpesquisacategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_pesquisa;
        private Label label1;
        private DataGridView datagridcategoria;
    }
}