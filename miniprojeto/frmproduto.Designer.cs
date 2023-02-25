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
            this.bto_codigo = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_valorcusto = new System.Windows.Forms.TextBox();
            this.txt_valorvenda = new System.Windows.Forms.TextBox();
            this.txt_unidade = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_codigocategoria = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bto_codigo);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bto_codigo
            // 
            this.bto_codigo.Location = new System.Drawing.Point(137, 38);
            this.bto_codigo.Name = "bto_codigo";
            this.bto_codigo.Size = new System.Drawing.Size(35, 23);
            this.bto_codigo.TabIndex = 2;
            this.bto_codigo.Text = "...";
            this.bto_codigo.UseVisualStyleBackColor = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(8, 38);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 23);
            this.txt_codigo.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.cbo_status);
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.txt_valorcusto);
            this.groupBox2.Controls.Add(this.txt_valorvenda);
            this.groupBox2.Controls.Add(this.txt_unidade);
            this.groupBox2.Controls.Add(this.txt_peso);
            this.groupBox2.Controls.Add(this.txt_qtd);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.txt_codigocategoria);
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
            this.groupBox2.Size = new System.Drawing.Size(474, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbo_status
            // 
            this.cbo_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Location = new System.Drawing.Point(221, 91);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(94, 23);
            this.cbo_status.TabIndex = 4;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(8, 146);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(436, 88);
            this.txt_obs.TabIndex = 3;
            this.txt_obs.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txt_valorcusto
            // 
            this.txt_valorcusto.Location = new System.Drawing.Point(8, 91);
            this.txt_valorcusto.Name = "txt_valorcusto";
            this.txt_valorcusto.Size = new System.Drawing.Size(100, 23);
            this.txt_valorcusto.TabIndex = 3;
            this.txt_valorcusto.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txt_valorvenda
            // 
            this.txt_valorvenda.Location = new System.Drawing.Point(114, 91);
            this.txt_valorvenda.Name = "txt_valorvenda";
            this.txt_valorvenda.Size = new System.Drawing.Size(100, 23);
            this.txt_valorvenda.TabIndex = 3;
            // 
            // txt_unidade
            // 
            this.txt_unidade.Location = new System.Drawing.Point(384, 37);
            this.txt_unidade.Name = "txt_unidade";
            this.txt_unidade.Size = new System.Drawing.Size(60, 23);
            this.txt_unidade.TabIndex = 2;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(318, 37);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(60, 23);
            this.txt_peso.TabIndex = 2;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(252, 37);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(60, 23);
            this.txt_qtd.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(8, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(238, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_codigocategoria
            // 
            this.txt_codigocategoria.Location = new System.Drawing.Point(321, 91);
            this.txt_codigocategoria.Name = "txt_codigocategoria";
            this.txt_codigocategoria.Size = new System.Drawing.Size(123, 23);
            this.txt_codigocategoria.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo da Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 19);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 36);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(52, 11);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 0;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(133, 11);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 0;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(214, 11);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 0;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(295, 11);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 0;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(376, 11);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 0;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            // 
            // frmproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmproduto";
            this.Text = "Cadastro de produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button bto_codigo;
        private TextBox txt_codigo;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cbo_status;
        private TextBox txt_valorcusto;
        private TextBox txt_valorvenda;
        private TextBox txt_unidade;
        private TextBox txt_peso;
        private TextBox txt_qtd;
        private TextBox txt_nome;
        private TextBox txt_codigocategoria;
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
    }
}