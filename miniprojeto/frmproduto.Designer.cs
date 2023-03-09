namespace N8_miniprojeto
{
    partial class frmproduto
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
            this.bto_pesquisaavancada = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.bto_codigoproduto = new System.Windows.Forms.Button();
            this.txt_codigoproduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_unidade = new System.Windows.Forms.ComboBox();
            this.cbo_codigocategoria = new System.Windows.Forms.ComboBox();
            this.cbo_nomecategoria = new System.Windows.Forms.ComboBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_valorcusto = new System.Windows.Forms.TextBox();
            this.txt_valorvenda = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_qtde = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagridproduto = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bto_pesquisaavancada);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl_cadastro);
            this.groupBox1.Controls.Add(this.bto_codigoproduto);
            this.groupBox1.Controls.Add(this.txt_codigoproduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bto_pesquisaavancada
            // 
            this.bto_pesquisaavancada.Location = new System.Drawing.Point(178, 38);
            this.bto_pesquisaavancada.Name = "bto_pesquisaavancada";
            this.bto_pesquisaavancada.Size = new System.Drawing.Size(137, 23);
            this.bto_pesquisaavancada.TabIndex = 5;
            this.bto_pesquisaavancada.Text = "Pesquisar Produto";
            this.bto_pesquisaavancada.UseVisualStyleBackColor = true;
            this.bto_pesquisaavancada.Click += new System.EventHandler(this.bto_pesquisaavancada_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Data de Cadastro";
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cadastro.Location = new System.Drawing.Point(417, 38);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(147, 23);
            this.lbl_cadastro.TabIndex = 3;
            // 
            // bto_codigoproduto
            // 
            this.bto_codigoproduto.Location = new System.Drawing.Point(137, 38);
            this.bto_codigoproduto.Name = "bto_codigoproduto";
            this.bto_codigoproduto.Size = new System.Drawing.Size(35, 23);
            this.bto_codigoproduto.TabIndex = 1;
            this.bto_codigoproduto.Text = "...";
            this.bto_codigoproduto.UseVisualStyleBackColor = true;
            this.bto_codigoproduto.Click += new System.EventHandler(this.bto_codigoproduto_Click);
            // 
            // txt_codigoproduto
            // 
            this.txt_codigoproduto.Location = new System.Drawing.Point(8, 38);
            this.txt_codigoproduto.Name = "txt_codigoproduto";
            this.txt_codigoproduto.Size = new System.Drawing.Size(123, 23);
            this.txt_codigoproduto.TabIndex = 0;
            this.txt_codigoproduto.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigoproduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoproduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_unidade);
            this.groupBox2.Controls.Add(this.cbo_codigocategoria);
            this.groupBox2.Controls.Add(this.cbo_nomecategoria);
            this.groupBox2.Controls.Add(this.cbo_status);
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.txt_valorcusto);
            this.groupBox2.Controls.Add(this.txt_valorvenda);
            this.groupBox2.Controls.Add(this.txt_peso);
            this.groupBox2.Controls.Add(this.txt_qtde);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbo_unidade
            // 
            this.cbo_unidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_unidade.FormattingEnabled = true;
            this.cbo_unidade.Items.AddRange(new object[] {
            "KG",
            "G",
            "L",
            "ML"});
            this.cbo_unidade.Location = new System.Drawing.Point(504, 37);
            this.cbo_unidade.Name = "cbo_unidade";
            this.cbo_unidade.Size = new System.Drawing.Size(60, 23);
            this.cbo_unidade.TabIndex = 5;
            // 
            // cbo_codigocategoria
            // 
            this.cbo_codigocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_codigocategoria.FormattingEnabled = true;
            this.cbo_codigocategoria.Location = new System.Drawing.Point(443, 91);
            this.cbo_codigocategoria.Name = "cbo_codigocategoria";
            this.cbo_codigocategoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_codigocategoria.TabIndex = 10;
            this.cbo_codigocategoria.SelectedIndexChanged += new System.EventHandler(this.cbo_codigocategoria_SelectedIndexChanged);
            // 
            // cbo_nomecategoria
            // 
            this.cbo_nomecategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nomecategoria.FormattingEnabled = true;
            this.cbo_nomecategoria.Location = new System.Drawing.Point(318, 91);
            this.cbo_nomecategoria.Name = "cbo_nomecategoria";
            this.cbo_nomecategoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_nomecategoria.TabIndex = 9;
            this.cbo_nomecategoria.SelectedIndexChanged += new System.EventHandler(this.cbo_nomecategoria_SelectedIndexChanged);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(220, 91);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(95, 23);
            this.cbo_status.TabIndex = 8;
            this.cbo_status.SelectedIndexChanged += new System.EventHandler(this.cbo_status_SelectedIndexChanged);
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(8, 146);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(556, 88);
            this.txt_obs.TabIndex = 11;
            this.txt_obs.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txt_valorcusto
            // 
            this.txt_valorcusto.Location = new System.Drawing.Point(8, 91);
            this.txt_valorcusto.Name = "txt_valorcusto";
            this.txt_valorcusto.Size = new System.Drawing.Size(100, 23);
            this.txt_valorcusto.TabIndex = 6;
            this.txt_valorcusto.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txt_valorcusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorcusto_KeyPress);
            // 
            // txt_valorvenda
            // 
            this.txt_valorvenda.Location = new System.Drawing.Point(114, 91);
            this.txt_valorvenda.Name = "txt_valorvenda";
            this.txt_valorvenda.Size = new System.Drawing.Size(100, 23);
            this.txt_valorvenda.TabIndex = 7;
            this.txt_valorvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorvenda_KeyPress);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(440, 37);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(60, 23);
            this.txt_peso.TabIndex = 4;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // txt_qtde
            // 
            this.txt_qtde.Location = new System.Drawing.Point(374, 37);
            this.txt_qtde.Name = "txt_qtde";
            this.txt_qtde.Size = new System.Drawing.Size(60, 23);
            this.txt_qtde.TabIndex = 3;
            this.txt_qtde.TextChanged += new System.EventHandler(this.txt_qtde_TextChanged);
            this.txt_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtde_KeyPress);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(8, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(360, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo da Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Qtd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Valor de custo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Observação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome do Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Valor de venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bto_cadastrar);
            this.groupBox3.Controls.Add(this.bto_alterar);
            this.groupBox3.Controls.Add(this.bto_limpar);
            this.groupBox3.Controls.Add(this.bto_excluir);
            this.groupBox3.Controls.Add(this.bto_sair);
            this.groupBox3.Location = new System.Drawing.Point(121, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 36);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(52, 11);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 12;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(133, 11);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 13;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(214, 11);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 14;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(295, 11);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 15;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            this.bto_excluir.Click += new System.EventHandler(this.bto_excluir_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(376, 11);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 16;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagridproduto);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_pesquisar);
            this.groupBox4.Location = new System.Drawing.Point(591, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 362);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // datagridproduto
            // 
            this.datagridproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridproduto.Location = new System.Drawing.Point(6, 68);
            this.datagridproduto.Name = "datagridproduto";
            this.datagridproduto.ReadOnly = true;
            this.datagridproduto.RowTemplate.Height = 25;
            this.datagridproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridproduto.Size = new System.Drawing.Size(379, 288);
            this.datagridproduto.TabIndex = 2;
            this.datagridproduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridproduto_CellClick);
            this.datagridproduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridproduto_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pesquisar Produto";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(6, 39);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(379, 23);
            this.txt_pesquisar.TabIndex = 17;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // frmproduto
            // 
            this.AcceptButton = this.bto_cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bto_sair;
            this.ClientSize = new System.Drawing.Size(590, 386);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmproduto";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.frmproduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button bto_codigoproduto;
        private TextBox txt_codigoproduto;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_valorcusto;
        private TextBox txt_valorvenda;
        private TextBox txt_peso;
        private TextBox txt_qtde;
        private TextBox txt_nome;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label2;
        private TextBox txt_obs;
        private GroupBox groupBox3;
        private Button bto_cadastrar;
        private Button bto_alterar;
        private Button bto_limpar;
        private Button bto_excluir;
        private Button bto_sair;
        private ComboBox cbo_status;
        private Label label12;
        private Label lbl_cadastro;
        private Label label11;
        private ComboBox cbo_codigocategoria;
        private ComboBox cbo_nomecategoria;
        private ComboBox cbo_unidade;
        private GroupBox groupBox4;
        private DataGridView datagridproduto;
        private Label label13;
        private TextBox txt_pesquisar;
        private Button bto_pesquisaavancada;
    }
}