namespace N8_miniprojeto
{
    partial class frmminiprojeto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bto_codigo = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagridusuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bto_codigo);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.lbl_codigo);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bto_codigo
            // 
            this.bto_codigo.Location = new System.Drawing.Point(234, 37);
            this.bto_codigo.Name = "bto_codigo";
            this.bto_codigo.Size = new System.Drawing.Size(47, 24);
            this.bto_codigo.TabIndex = 1;
            this.bto_codigo.Text = "...";
            this.bto_codigo.UseVisualStyleBackColor = true;
            this.bto_codigo.Click += new System.EventHandler(this.bto_codigo_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(17, 37);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(211, 23);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(17, 19);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.lbl_status);
            this.groupBox2.Controls.Add(this.cbo_status);
            this.groupBox2.Controls.Add(this.lbl_cpf);
            this.groupBox2.Controls.Add(this.lbl_senha);
            this.groupBox2.Controls.Add(this.mask_cpf);
            this.groupBox2.Controls.Add(this.txt_login);
            this.groupBox2.Controls.Add(this.txt_senha);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.lbl_obs);
            this.groupBox2.Controls.Add(this.lbl_login);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Location = new System.Drawing.Point(7, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(17, 145);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(487, 100);
            this.txt_obs.TabIndex = 7;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(409, 73);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status";
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(409, 91);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(95, 23);
            this.cbo_status.TabIndex = 6;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(287, 73);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(28, 15);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(152, 73);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(287, 91);
            this.mask_cpf.Mask = "###.###.###-##";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(116, 23);
            this.mask_cpf.TabIndex = 5;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(17, 91);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(129, 23);
            this.txt_login.TabIndex = 3;
            this.txt_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(152, 91);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(129, 23);
            this.txt_senha.TabIndex = 4;
            this.txt_senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(17, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(487, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(17, 127);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(69, 15);
            this.lbl_obs.TabIndex = 0;
            this.lbl_obs.Text = "Observação";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(17, 73);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 15);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(17, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bto_cadastrar);
            this.groupBox3.Controls.Add(this.bto_alterar);
            this.groupBox3.Controls.Add(this.bto_limpar);
            this.groupBox3.Controls.Add(this.bto_excluir);
            this.groupBox3.Controls.Add(this.bto_sair);
            this.groupBox3.Location = new System.Drawing.Point(7, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 37);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(71, 9);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 8;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(163, 9);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 9;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(254, 9);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 10;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(345, 9);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 11;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            this.bto_excluir.Click += new System.EventHandler(this.bto_excluir_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(431, 9);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 12;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagridusuario);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_pesquisar);
            this.groupBox4.Location = new System.Drawing.Point(528, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 384);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // datagridusuario
            // 
            this.datagridusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridusuario.Location = new System.Drawing.Point(6, 68);
            this.datagridusuario.Name = "datagridusuario";
            this.datagridusuario.ReadOnly = true;
            this.datagridusuario.RowTemplate.Height = 25;
            this.datagridusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridusuario.Size = new System.Drawing.Size(353, 311);
            this.datagridusuario.TabIndex = 2;
            this.datagridusuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridusuario_CellClick);
            this.datagridusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "Pesquisar usuário";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(6, 39);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(353, 23);
            this.txt_pesquisar.TabIndex = 13;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // frmminiprojeto
            // 
            this.AcceptButton = this.bto_cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bto_sair;
            this.ClientSize = new System.Drawing.Size(906, 399);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmminiprojeto";
            this.Text = "Cadastro de usuario";
            this.Load += new System.EventHandler(this.frmminiprojeto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button bto_codigo;
        private TextBox txt_codigo;
        private Label lbl_codigo;
        private GroupBox groupBox2;
        private TextBox txt_senha;
        private TextBox txt_nome;
        private Label lbl_login;
        private Label lbl_nome;
        private TextBox txt_obs;
        private Label lbl_status;
        private ComboBox cbo_status;
        private Label lbl_cpf;
        private Label lbl_senha;
        private MaskedTextBox mask_cpf;
        private TextBox txt_login;
        private Label lbl_obs;
        private GroupBox groupBox3;
        private Button bto_cadastrar;
        private Button bto_alterar;
        private Button bto_limpar;
        private Button bto_excluir;
        private Button bto_sair;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox txt_pesquisar;
        private DataGridView datagridusuario;
    }
}