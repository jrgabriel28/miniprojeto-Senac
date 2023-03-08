namespace N8_miniprojeto
{
    partial class frmpesquisausuario
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
            this.datausuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datausuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(12, 33);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(577, 23);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // datausuario
            // 
            this.datausuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datausuario.Location = new System.Drawing.Point(12, 62);
            this.datausuario.Name = "datausuario";
            this.datausuario.ReadOnly = true;
            this.datausuario.RowTemplate.Height = 25;
            this.datausuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datausuario.Size = new System.Drawing.Size(577, 376);
            this.datausuario.TabIndex = 1;
            this.datausuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datausuario_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Usuário";
            // 
            // frmpesquisausuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datausuario);
            this.Controls.Add(this.txt_pesquisa);
            this.Name = "frmpesquisausuario";
            this.Text = "Pesquisa Avançada de Usuário";
            this.Load += new System.EventHandler(this.frmpesquisausuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datausuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_pesquisa;
        private DataGridView datausuario;
        private Label label1;
    }
}