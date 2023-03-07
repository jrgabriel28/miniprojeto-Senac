namespace N8_miniprojeto
{
    partial class frmcategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bto_codigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_nomeP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagridecategoria = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridecategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bto_codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bto_codigo
            // 
            this.bto_codigo.Location = new System.Drawing.Point(145, 40);
            this.bto_codigo.Name = "bto_codigo";
            this.bto_codigo.Size = new System.Drawing.Size(41, 23);
            this.bto_codigo.TabIndex = 1;
            this.bto_codigo.Text = "...";
            this.bto_codigo.UseVisualStyleBackColor = true;
            this.bto_codigo.Click += new System.EventHandler(this.bto_codigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(17, 41);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(122, 23);
            this.txt_codigo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbo_status);
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.txt_descricao);
            this.groupBox2.Controls.Add(this.txt_nomeP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(25, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(396, 37);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(102, 23);
            this.cbo_status.TabIndex = 3;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(17, 193);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(481, 72);
            this.txt_obs.TabIndex = 5;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(17, 91);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(481, 72);
            this.txt_descricao.TabIndex = 4;
            // 
            // txt_nomeP
            // 
            this.txt_nomeP.Location = new System.Drawing.Point(17, 37);
            this.txt_nomeP.Name = "txt_nomeP";
            this.txt_nomeP.Size = new System.Drawing.Size(373, 23);
            this.txt_nomeP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome da categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descrição da categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Observação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bto_cadastrar);
            this.groupBox3.Controls.Add(this.bto_alterar);
            this.groupBox3.Controls.Add(this.bto_limpar);
            this.groupBox3.Controls.Add(this.bto_excluir);
            this.groupBox3.Controls.Add(this.bto_sair);
            this.groupBox3.Location = new System.Drawing.Point(25, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 38);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(99, 9);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 6;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(180, 9);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 7;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(261, 9);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 8;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(342, 9);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 9;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            this.bto_excluir.Click += new System.EventHandler(this.bto_excluir_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(423, 9);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 10;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagridecategoria);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_pesquisar);
            this.groupBox4.Location = new System.Drawing.Point(539, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 401);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // datagridecategoria
            // 
            this.datagridecategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridecategoria.Location = new System.Drawing.Point(6, 70);
            this.datagridecategoria.Name = "datagridecategoria";
            this.datagridecategoria.ReadOnly = true;
            this.datagridecategoria.RowTemplate.Height = 25;
            this.datagridecategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridecategoria.Size = new System.Drawing.Size(346, 325);
            this.datagridecategoria.TabIndex = 2;
            this.datagridecategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridecategoria_CellClick);
            this.datagridecategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridecategoria_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pesquisar Categoria";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(6, 41);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(346, 23);
            this.txt_pesquisar.TabIndex = 11;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmcategoria
            // 
            this.AcceptButton = this.bto_cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bto_sair;
            this.ClientSize = new System.Drawing.Size(909, 426);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmcategoria";
            this.Text = "Cadastro do Categoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridecategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button bto_codigo;
        private Label label1;
        private TextBox txt_codigo;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cbo_status;
        private TextBox txt_obs;
        private TextBox txt_descricao;
        private TextBox txt_nomeP;
        private Label label4;
        private Label label5;
        private Label label2;
        private GroupBox groupBox3;
        private Button bto_cadastrar;
        private Button bto_alterar;
        private Button bto_limpar;
        private Button bto_excluir;
        private Button bto_sair;
        private GroupBox groupBox4;
        private DataGridView datagridecategoria;
        private Label label6;
        private TextBox txt_pesquisar;
    }
}