namespace Devs2Blu.Projetos.SistemaCadastro.Forms
{
    partial class FormMain
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
            this.cbox_Convenio = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.gbox_cadastro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbBox_rbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.cbox_StatusPessoa = new System.Windows.Forms.ComboBox();
            this.llbNome = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.masktxtb_CGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.gbox_Editar = new System.Windows.Forms.GroupBox();
            this.txtb_idExcluir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Exluir = new System.Windows.Forms.Button();
            this.gbox_Paciente = new System.Windows.Forms.GroupBox();
            this.txtb_Risco = new System.Windows.Forms.TextBox();
            this.cbox_Obito = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Obito = new System.Windows.Forms.Label();
            this.cbox_StatusPaciente = new System.Windows.Forms.ComboBox();
            this.lbl_Risco = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BuscaPaciente = new System.Windows.Forms.Button();
            this.lbl_IdAlterar = new System.Windows.Forms.Label();
            this.txtb_idAlteracao = new System.Windows.Forms.TextBox();
            this.rb_Alterar = new System.Windows.Forms.RadioButton();
            this.rb_Cadastrar = new System.Windows.Forms.RadioButton();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.gbox_Endereco = new System.Windows.Forms.GroupBox();
            this.masktxtb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txtb_Numero = new System.Windows.Forms.TextBox();
            this.txtb_Rua = new System.Windows.Forms.TextBox();
            this.txtb_Bairro = new System.Windows.Forms.TextBox();
            this.txtb_Cidade = new System.Windows.Forms.TextBox();
            this.cbox_UF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.grid_Pacientes = new System.Windows.Forms.DataGridView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label8 = new System.Windows.Forms.Label();
            this.gbox_cadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBox_rbTipoPessoa.SuspendLayout();
            this.gbox_Editar.SuspendLayout();
            this.gbox_Paciente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox_Endereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_Convenio
            // 
            this.cbox_Convenio.FormattingEnabled = true;
            this.cbox_Convenio.Location = new System.Drawing.Point(87, 69);
            this.cbox_Convenio.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_Convenio.Name = "cbox_Convenio";
            this.cbox_Convenio.Size = new System.Drawing.Size(152, 24);
            this.cbox_Convenio.TabIndex = 0;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(13, 73);
            this.lblConvenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(67, 16);
            this.lblConvenio.TabIndex = 1;
            this.lblConvenio.Text = "Convênio:";
            // 
            // gbox_cadastro
            // 
            this.gbox_cadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbox_cadastro.Controls.Add(this.button1);
            this.gbox_cadastro.Controls.Add(this.groupBox1);
            this.gbox_cadastro.Controls.Add(this.gbox_Editar);
            this.gbox_cadastro.Controls.Add(this.gbox_Paciente);
            this.gbox_cadastro.Controls.Add(this.groupBox2);
            this.gbox_cadastro.Controls.Add(this.btn_Salvar);
            this.gbox_cadastro.Controls.Add(this.gbox_Endereco);
            this.gbox_cadastro.Controls.Add(this.btn_Limpar);
            this.gbox_cadastro.Location = new System.Drawing.Point(16, 36);
            this.gbox_cadastro.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_cadastro.Name = "gbox_cadastro";
            this.gbox_cadastro.Padding = new System.Windows.Forms.Padding(4);
            this.gbox_cadastro.Size = new System.Drawing.Size(1901, 256);
            this.gbox_cadastro.TabIndex = 2;
            this.gbox_cadastro.TabStop = false;
            this.gbox_cadastro.Text = "Formulário de Cadastro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb_Nome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gbBox_rbTipoPessoa);
            this.groupBox1.Controls.Add(this.cbox_StatusPessoa);
            this.groupBox1.Controls.Add(this.llbNome);
            this.groupBox1.Controls.Add(this.lblCGCCPF);
            this.groupBox1.Controls.Add(this.masktxtb_CGCCPF);
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 161);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoa";
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Location = new System.Drawing.Point(100, 25);
            this.txtb_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(340, 22);
            this.txtb_Nome.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Status:";
            // 
            // gbBox_rbTipoPessoa
            // 
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbJuridica);
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbFisica);
            this.gbBox_rbTipoPessoa.Location = new System.Drawing.Point(13, 105);
            this.gbBox_rbTipoPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.gbBox_rbTipoPessoa.Name = "gbBox_rbTipoPessoa";
            this.gbBox_rbTipoPessoa.Padding = new System.Windows.Forms.Padding(4);
            this.gbBox_rbTipoPessoa.Size = new System.Drawing.Size(195, 44);
            this.gbBox_rbTipoPessoa.TabIndex = 3;
            this.gbBox_rbTipoPessoa.TabStop = false;
            this.gbBox_rbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(100, 17);
            this.rbJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(75, 20);
            this.rbJuridica.TabIndex = 4;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(16, 17);
            this.rbFisica.Margin = new System.Windows.Forms.Padding(4);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(64, 20);
            this.rbFisica.TabIndex = 3;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // cbox_StatusPessoa
            // 
            this.cbox_StatusPessoa.Enabled = false;
            this.cbox_StatusPessoa.FormattingEnabled = true;
            this.cbox_StatusPessoa.Location = new System.Drawing.Point(360, 66);
            this.cbox_StatusPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_StatusPessoa.Name = "cbox_StatusPessoa";
            this.cbox_StatusPessoa.Size = new System.Drawing.Size(79, 24);
            this.cbox_StatusPessoa.TabIndex = 25;
            // 
            // llbNome
            // 
            this.llbNome.AutoSize = true;
            this.llbNome.Location = new System.Drawing.Point(23, 28);
            this.llbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbNome.Name = "llbNome";
            this.llbNome.Size = new System.Drawing.Size(47, 16);
            this.llbNome.TabIndex = 4;
            this.llbNome.Text = "Nome:";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(23, 70);
            this.lblCGCCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(36, 16);
            this.lblCGCCPF.TabIndex = 5;
            this.lblCGCCPF.Text = "CPF:";
            // 
            // masktxtb_CGCCPF
            // 
            this.masktxtb_CGCCPF.Location = new System.Drawing.Point(100, 66);
            this.masktxtb_CGCCPF.Margin = new System.Windows.Forms.Padding(4);
            this.masktxtb_CGCCPF.Name = "masktxtb_CGCCPF";
            this.masktxtb_CGCCPF.Size = new System.Drawing.Size(173, 22);
            this.masktxtb_CGCCPF.TabIndex = 18;
            this.masktxtb_CGCCPF.Text = "___.___.___-__";
            // 
            // gbox_Editar
            // 
            this.gbox_Editar.BackColor = System.Drawing.Color.RosyBrown;
            this.gbox_Editar.Controls.Add(this.txtb_idExcluir);
            this.gbox_Editar.Controls.Add(this.label10);
            this.gbox_Editar.Controls.Add(this.btn_Exluir);
            this.gbox_Editar.Location = new System.Drawing.Point(1437, 122);
            this.gbox_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_Editar.Name = "gbox_Editar";
            this.gbox_Editar.Padding = new System.Windows.Forms.Padding(4);
            this.gbox_Editar.Size = new System.Drawing.Size(451, 63);
            this.gbox_Editar.TabIndex = 27;
            this.gbox_Editar.TabStop = false;
            this.gbox_Editar.Text = "Excluir Registro";
            // 
            // txtb_idExcluir
            // 
            this.txtb_idExcluir.Location = new System.Drawing.Point(109, 22);
            this.txtb_idExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_idExcluir.Name = "txtb_idExcluir";
            this.txtb_idExcluir.Size = new System.Drawing.Size(144, 22);
            this.txtb_idExcluir.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Id à excluir:";
            // 
            // btn_Exluir
            // 
            this.btn_Exluir.Location = new System.Drawing.Point(268, 15);
            this.btn_Exluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exluir.Name = "btn_Exluir";
            this.btn_Exluir.Size = new System.Drawing.Size(169, 39);
            this.btn_Exluir.TabIndex = 2;
            this.btn_Exluir.Text = "Excluir";
            this.btn_Exluir.UseVisualStyleBackColor = true;
            this.btn_Exluir.Click += new System.EventHandler(this.btn_Exluir_Click);
            // 
            // gbox_Paciente
            // 
            this.gbox_Paciente.Controls.Add(this.txtb_Risco);
            this.gbox_Paciente.Controls.Add(this.cbox_Obito);
            this.gbox_Paciente.Controls.Add(this.lbl_Status);
            this.gbox_Paciente.Controls.Add(this.lbl_Obito);
            this.gbox_Paciente.Controls.Add(this.cbox_StatusPaciente);
            this.gbox_Paciente.Controls.Add(this.lbl_Risco);
            this.gbox_Paciente.Controls.Add(this.lblConvenio);
            this.gbox_Paciente.Controls.Add(this.cbox_Convenio);
            this.gbox_Paciente.Location = new System.Drawing.Point(976, 23);
            this.gbox_Paciente.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_Paciente.Name = "gbox_Paciente";
            this.gbox_Paciente.Padding = new System.Windows.Forms.Padding(4);
            this.gbox_Paciente.Size = new System.Drawing.Size(447, 161);
            this.gbox_Paciente.TabIndex = 25;
            this.gbox_Paciente.TabStop = false;
            this.gbox_Paciente.Text = "Dados Paciente";
            // 
            // txtb_Risco
            // 
            this.txtb_Risco.Location = new System.Drawing.Point(284, 28);
            this.txtb_Risco.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Risco.Name = "txtb_Risco";
            this.txtb_Risco.Size = new System.Drawing.Size(144, 22);
            this.txtb_Risco.TabIndex = 18;
            // 
            // cbox_Obito
            // 
            this.cbox_Obito.Enabled = false;
            this.cbox_Obito.FormattingEnabled = true;
            this.cbox_Obito.Location = new System.Drawing.Point(323, 69);
            this.cbox_Obito.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_Obito.Name = "cbox_Obito";
            this.cbox_Obito.Size = new System.Drawing.Size(67, 24);
            this.cbox_Obito.TabIndex = 24;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(13, 32);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(47, 16);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Status:";
            // 
            // lbl_Obito
            // 
            this.lbl_Obito.AutoSize = true;
            this.lbl_Obito.Location = new System.Drawing.Point(265, 73);
            this.lbl_Obito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Obito.Name = "lbl_Obito";
            this.lbl_Obito.Size = new System.Drawing.Size(46, 16);
            this.lbl_Obito.TabIndex = 23;
            this.lbl_Obito.Text = "Obito?";
            // 
            // cbox_StatusPaciente
            // 
            this.cbox_StatusPaciente.Enabled = false;
            this.cbox_StatusPaciente.FormattingEnabled = true;
            this.cbox_StatusPaciente.Location = new System.Drawing.Point(87, 30);
            this.cbox_StatusPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_StatusPaciente.Name = "cbox_StatusPaciente";
            this.cbox_StatusPaciente.Size = new System.Drawing.Size(79, 24);
            this.cbox_StatusPaciente.TabIndex = 18;
            // 
            // lbl_Risco
            // 
            this.lbl_Risco.AutoSize = true;
            this.lbl_Risco.Location = new System.Drawing.Point(176, 32);
            this.lbl_Risco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Risco.Name = "lbl_Risco";
            this.lbl_Risco.Size = new System.Drawing.Size(101, 16);
            this.lbl_Risco.TabIndex = 22;
            this.lbl_Risco.Text = "Paciente Risco:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.btn_BuscaPaciente);
            this.groupBox2.Controls.Add(this.lbl_IdAlterar);
            this.groupBox2.Controls.Add(this.txtb_idAlteracao);
            this.groupBox2.Controls.Add(this.rb_Alterar);
            this.groupBox2.Controls.Add(this.rb_Cadastrar);
            this.groupBox2.Location = new System.Drawing.Point(1437, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(451, 92);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar Dados";
            // 
            // btn_BuscaPaciente
            // 
            this.btn_BuscaPaciente.Location = new System.Drawing.Point(292, 52);
            this.btn_BuscaPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscaPaciente.Name = "btn_BuscaPaciente";
            this.btn_BuscaPaciente.Size = new System.Drawing.Size(145, 28);
            this.btn_BuscaPaciente.TabIndex = 14;
            this.btn_BuscaPaciente.Text = "Buscar";
            this.btn_BuscaPaciente.UseVisualStyleBackColor = true;
            this.btn_BuscaPaciente.Visible = false;
            this.btn_BuscaPaciente.Click += new System.EventHandler(this.btn_BuscaPaciente_Click);
            // 
            // lbl_IdAlterar
            // 
            this.lbl_IdAlterar.AutoSize = true;
            this.lbl_IdAlterar.Location = new System.Drawing.Point(199, 41);
            this.lbl_IdAlterar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdAlterar.Name = "lbl_IdAlterar";
            this.lbl_IdAlterar.Size = new System.Drawing.Size(73, 16);
            this.lbl_IdAlterar.TabIndex = 26;
            this.lbl_IdAlterar.Text = "Id à alterar:";
            this.lbl_IdAlterar.Visible = false;
            // 
            // txtb_idAlteracao
            // 
            this.txtb_idAlteracao.Enabled = false;
            this.txtb_idAlteracao.Location = new System.Drawing.Point(292, 21);
            this.txtb_idAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_idAlteracao.Name = "txtb_idAlteracao";
            this.txtb_idAlteracao.Size = new System.Drawing.Size(144, 22);
            this.txtb_idAlteracao.TabIndex = 25;
            this.txtb_idAlteracao.Visible = false;
            // 
            // rb_Alterar
            // 
            this.rb_Alterar.AutoSize = true;
            this.rb_Alterar.Location = new System.Drawing.Point(116, 38);
            this.rb_Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Alterar.Name = "rb_Alterar";
            this.rb_Alterar.Size = new System.Drawing.Size(67, 20);
            this.rb_Alterar.TabIndex = 29;
            this.rb_Alterar.Text = "Alterar";
            this.rb_Alterar.UseVisualStyleBackColor = true;
            this.rb_Alterar.CheckedChanged += new System.EventHandler(this.rb_Alterar_CheckedChanged);
            // 
            // rb_Cadastrar
            // 
            this.rb_Cadastrar.AutoSize = true;
            this.rb_Cadastrar.Checked = true;
            this.rb_Cadastrar.Location = new System.Drawing.Point(17, 38);
            this.rb_Cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Cadastrar.Name = "rb_Cadastrar";
            this.rb_Cadastrar.Size = new System.Drawing.Size(87, 20);
            this.rb_Cadastrar.TabIndex = 5;
            this.rb_Cadastrar.TabStop = true;
            this.rb_Cadastrar.Text = "Cadastrar";
            this.rb_Cadastrar.UseVisualStyleBackColor = true;
            this.rb_Cadastrar.CheckedChanged += new System.EventHandler(this.rb_Cadastrar_CheckedChanged);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(20, 197);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(331, 44);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // gbox_Endereco
            // 
            this.gbox_Endereco.BackColor = System.Drawing.Color.LightGray;
            this.gbox_Endereco.Controls.Add(this.masktxtb_CEP);
            this.gbox_Endereco.Controls.Add(this.txtb_Numero);
            this.gbox_Endereco.Controls.Add(this.txtb_Rua);
            this.gbox_Endereco.Controls.Add(this.txtb_Bairro);
            this.gbox_Endereco.Controls.Add(this.txtb_Cidade);
            this.gbox_Endereco.Controls.Add(this.cbox_UF);
            this.gbox_Endereco.Controls.Add(this.label6);
            this.gbox_Endereco.Controls.Add(this.label5);
            this.gbox_Endereco.Controls.Add(this.label4);
            this.gbox_Endereco.Controls.Add(this.label3);
            this.gbox_Endereco.Controls.Add(this.label2);
            this.gbox_Endereco.Controls.Add(this.label1);
            this.gbox_Endereco.Location = new System.Drawing.Point(505, 23);
            this.gbox_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_Endereco.Name = "gbox_Endereco";
            this.gbox_Endereco.Padding = new System.Windows.Forms.Padding(4);
            this.gbox_Endereco.Size = new System.Drawing.Size(448, 161);
            this.gbox_Endereco.TabIndex = 3;
            this.gbox_Endereco.TabStop = false;
            this.gbox_Endereco.Text = "Endereço / Contato";
            this.gbox_Endereco.Enter += new System.EventHandler(this.gbox_Endereco_Enter);
            // 
            // masktxtb_CEP
            // 
            this.masktxtb_CEP.Location = new System.Drawing.Point(71, 28);
            this.masktxtb_CEP.Margin = new System.Windows.Forms.Padding(4);
            this.masktxtb_CEP.Name = "masktxtb_CEP";
            this.masktxtb_CEP.Size = new System.Drawing.Size(153, 22);
            this.masktxtb_CEP.TabIndex = 3;
            this.masktxtb_CEP.Text = "__.___-__";
            this.masktxtb_CEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masktxtb_CEP_MaskInputRejected);
            this.masktxtb_CEP.TextChanged += new System.EventHandler(this.masktxtb_CEP_TextChanged_1);
            // 
            // txtb_Numero
            // 
            this.txtb_Numero.Location = new System.Drawing.Point(339, 110);
            this.txtb_Numero.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Numero.Name = "txtb_Numero";
            this.txtb_Numero.Size = new System.Drawing.Size(83, 22);
            this.txtb_Numero.TabIndex = 17;
            // 
            // txtb_Rua
            // 
            this.txtb_Rua.Location = new System.Drawing.Point(71, 110);
            this.txtb_Rua.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Rua.Name = "txtb_Rua";
            this.txtb_Rua.Size = new System.Drawing.Size(195, 22);
            this.txtb_Rua.TabIndex = 16;
            // 
            // txtb_Bairro
            // 
            this.txtb_Bairro.Location = new System.Drawing.Point(288, 69);
            this.txtb_Bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Bairro.Name = "txtb_Bairro";
            this.txtb_Bairro.Size = new System.Drawing.Size(133, 22);
            this.txtb_Bairro.TabIndex = 15;
            // 
            // txtb_Cidade
            // 
            this.txtb_Cidade.Location = new System.Drawing.Point(71, 69);
            this.txtb_Cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Cidade.Name = "txtb_Cidade";
            this.txtb_Cidade.Size = new System.Drawing.Size(153, 22);
            this.txtb_Cidade.TabIndex = 14;
            // 
            // cbox_UF
            // 
            this.cbox_UF.FormattingEnabled = true;
            this.cbox_UF.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cbox_UF.Location = new System.Drawing.Point(288, 28);
            this.cbox_UF.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_UF.Name = "cbox_UF";
            this.cbox_UF.Size = new System.Drawing.Size(133, 24);
            this.cbox_UF.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "CEP:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(376, 197);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(109, 44);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // grid_Pacientes
            // 
            this.grid_Pacientes.AllowUserToAddRows = false;
            this.grid_Pacientes.AllowUserToOrderColumns = true;
            this.grid_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Pacientes.Location = new System.Drawing.Point(16, 332);
            this.grid_Pacientes.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Pacientes.Name = "grid_Pacientes";
            this.grid_Pacientes.ReadOnly = true;
            this.grid_Pacientes.RowHeadersWidth = 51;
            this.grid_Pacientes.Size = new System.Drawing.Size(1901, 542);
            this.grid_Pacientes.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1933, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dados:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 889);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grid_Pacientes);
            this.Controls.Add(this.gbox_cadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_cadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBox_rbTipoPessoa.ResumeLayout(false);
            this.gbBox_rbTipoPessoa.PerformLayout();
            this.gbox_Editar.ResumeLayout(false);
            this.gbox_Editar.PerformLayout();
            this.gbox_Paciente.ResumeLayout(false);
            this.gbox_Paciente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbox_Endereco.ResumeLayout(false);
            this.gbox_Endereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_Convenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.GroupBox gbox_cadastro;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label llbNome;
        private System.Windows.Forms.GroupBox gbBox_rbTipoPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.GroupBox gbox_Endereco;
        private System.Windows.Forms.TextBox txtb_Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_Numero;
        private System.Windows.Forms.TextBox txtb_Rua;
        private System.Windows.Forms.TextBox txtb_Bairro;
        private System.Windows.Forms.TextBox txtb_Cidade;
        private System.Windows.Forms.ComboBox cbox_UF;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.MaskedTextBox masktxtb_CEP;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.DataGridView grid_Pacientes;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MaskedTextBox masktxtb_CGCCPF;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox cbox_StatusPaciente;
        private System.Windows.Forms.Label lbl_Risco;
        private System.Windows.Forms.GroupBox gbox_Paciente;
        private System.Windows.Forms.ComboBox cbox_Obito;
        private System.Windows.Forms.Label lbl_Obito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_StatusPessoa;
        private System.Windows.Forms.TextBox txtb_Risco;
        private System.Windows.Forms.GroupBox gbox_Editar;
        private System.Windows.Forms.Button btn_Exluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Alterar;
        private System.Windows.Forms.RadioButton rb_Cadastrar;
        private System.Windows.Forms.TextBox txtb_idAlteracao;
        private System.Windows.Forms.TextBox txtb_idExcluir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_IdAlterar;
        private System.Windows.Forms.Button btn_BuscaPaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

