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
            this.cbbox_Convenio = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.gbox_cadastro = new System.Windows.Forms.GroupBox();
            this.masktxtb_CGCCPF = new System.Windows.Forms.MaskedTextBox();
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
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.llbNome = new System.Windows.Forms.Label();
            this.gbBox_rbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.grid_Pacientes = new System.Windows.Forms.DataGridView();
            this.gbox_Conteudo = new System.Windows.Forms.GroupBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cbox_StatusPaciente = new System.Windows.Forms.ComboBox();
            this.lbl_Risco = new System.Windows.Forms.Label();
            this.lbl_Obito = new System.Windows.Forms.Label();
            this.cbox_Obito = new System.Windows.Forms.ComboBox();
            this.gbox_Paciente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_StatusPessoa = new System.Windows.Forms.ComboBox();
            this.txtb_Risco = new System.Windows.Forms.TextBox();
            this.gbox_cadastro.SuspendLayout();
            this.gbox_Endereco.SuspendLayout();
            this.gbBox_rbTipoPessoa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pacientes)).BeginInit();
            this.gbox_Conteudo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbox_Paciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbox_Convenio
            // 
            this.cbbox_Convenio.FormattingEnabled = true;
            this.cbbox_Convenio.Location = new System.Drawing.Point(68, 56);
            this.cbbox_Convenio.Name = "cbbox_Convenio";
            this.cbbox_Convenio.Size = new System.Drawing.Size(115, 21);
            this.cbbox_Convenio.TabIndex = 0;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(10, 59);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(55, 13);
            this.lblConvenio.TabIndex = 1;
            this.lblConvenio.Text = "Convênio:";
            // 
            // gbox_cadastro
            // 
            this.gbox_cadastro.Controls.Add(this.label7);
            this.gbox_cadastro.Controls.Add(this.cbox_StatusPessoa);
            this.gbox_cadastro.Controls.Add(this.gbox_Paciente);
            this.gbox_cadastro.Controls.Add(this.masktxtb_CGCCPF);
            this.gbox_cadastro.Controls.Add(this.btn_Salvar);
            this.gbox_cadastro.Controls.Add(this.gbox_Endereco);
            this.gbox_cadastro.Controls.Add(this.btn_Limpar);
            this.gbox_cadastro.Controls.Add(this.txtb_Nome);
            this.gbox_cadastro.Controls.Add(this.lblCGCCPF);
            this.gbox_cadastro.Controls.Add(this.llbNome);
            this.gbox_cadastro.Controls.Add(this.gbBox_rbTipoPessoa);
            this.gbox_cadastro.Location = new System.Drawing.Point(12, 29);
            this.gbox_cadastro.Name = "gbox_cadastro";
            this.gbox_cadastro.Size = new System.Drawing.Size(813, 329);
            this.gbox_cadastro.TabIndex = 2;
            this.gbox_cadastro.TabStop = false;
            this.gbox_cadastro.Text = "Formulário de Cadastro";
            // 
            // masktxtb_CGCCPF
            // 
            this.masktxtb_CGCCPF.Location = new System.Drawing.Point(79, 63);
            this.masktxtb_CGCCPF.Name = "masktxtb_CGCCPF";
            this.masktxtb_CGCCPF.Size = new System.Drawing.Size(131, 20);
            this.masktxtb_CGCCPF.TabIndex = 18;
            this.masktxtb_CGCCPF.Text = "___.___.___-__";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(10, 277);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(248, 36);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // gbox_Endereco
            // 
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
            this.gbox_Endereco.Location = new System.Drawing.Point(10, 145);
            this.gbox_Endereco.Name = "gbox_Endereco";
            this.gbox_Endereco.Size = new System.Drawing.Size(336, 122);
            this.gbox_Endereco.TabIndex = 3;
            this.gbox_Endereco.TabStop = false;
            this.gbox_Endereco.Text = "Endereço / Contato";
            // 
            // masktxtb_CEP
            // 
            this.masktxtb_CEP.Location = new System.Drawing.Point(53, 23);
            this.masktxtb_CEP.Name = "masktxtb_CEP";
            this.masktxtb_CEP.Size = new System.Drawing.Size(116, 20);
            this.masktxtb_CEP.TabIndex = 3;
            this.masktxtb_CEP.Text = "__.___-__";
            // 
            // txtb_Numero
            // 
            this.txtb_Numero.Location = new System.Drawing.Point(254, 89);
            this.txtb_Numero.Name = "txtb_Numero";
            this.txtb_Numero.Size = new System.Drawing.Size(63, 20);
            this.txtb_Numero.TabIndex = 17;
            // 
            // txtb_Rua
            // 
            this.txtb_Rua.Location = new System.Drawing.Point(53, 89);
            this.txtb_Rua.Name = "txtb_Rua";
            this.txtb_Rua.Size = new System.Drawing.Size(147, 20);
            this.txtb_Rua.TabIndex = 16;
            // 
            // txtb_Bairro
            // 
            this.txtb_Bairro.Location = new System.Drawing.Point(216, 56);
            this.txtb_Bairro.Name = "txtb_Bairro";
            this.txtb_Bairro.Size = new System.Drawing.Size(101, 20);
            this.txtb_Bairro.TabIndex = 15;
            // 
            // txtb_Cidade
            // 
            this.txtb_Cidade.Location = new System.Drawing.Point(53, 56);
            this.txtb_Cidade.Name = "txtb_Cidade";
            this.txtb_Cidade.Size = new System.Drawing.Size(116, 20);
            this.txtb_Cidade.TabIndex = 14;
            // 
            // cbox_UF
            // 
            this.cbox_UF.FormattingEnabled = true;
            this.cbox_UF.Location = new System.Drawing.Point(216, 23);
            this.cbox_UF.Name = "cbox_UF";
            this.cbox_UF.Size = new System.Drawing.Size(101, 21);
            this.cbox_UF.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CEP:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(264, 277);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(82, 36);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Location = new System.Drawing.Point(79, 25);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(256, 20);
            this.txtb_Nome.TabIndex = 6;
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(21, 66);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCGCCPF.TabIndex = 5;
            this.lblCGCCPF.Text = "CPF:";
            // 
            // llbNome
            // 
            this.llbNome.AutoSize = true;
            this.llbNome.Location = new System.Drawing.Point(21, 28);
            this.llbNome.Name = "llbNome";
            this.llbNome.Size = new System.Drawing.Size(38, 13);
            this.llbNome.TabIndex = 4;
            this.llbNome.Text = "Nome:";
            // 
            // gbBox_rbTipoPessoa
            // 
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbJuridica);
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbFisica);
            this.gbBox_rbTipoPessoa.Location = new System.Drawing.Point(13, 98);
            this.gbBox_rbTipoPessoa.Name = "gbBox_rbTipoPessoa";
            this.gbBox_rbTipoPessoa.Size = new System.Drawing.Size(146, 36);
            this.gbBox_rbTipoPessoa.TabIndex = 3;
            this.gbBox_rbTipoPessoa.TabStop = false;
            this.gbBox_rbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(75, 14);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 4;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(12, 14);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 3;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Info);
            this.panel1.Location = new System.Drawing.Point(12, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 65);
            this.panel1.TabIndex = 10;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(70, 6);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(57, 54);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(7, 6);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(57, 54);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.UseVisualStyleBackColor = true;
            // 
            // grid_Pacientes
            // 
            this.grid_Pacientes.AllowUserToAddRows = false;
            this.grid_Pacientes.AllowUserToOrderColumns = true;
            this.grid_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Pacientes.Location = new System.Drawing.Point(12, 18);
            this.grid_Pacientes.Name = "grid_Pacientes";
            this.grid_Pacientes.ReadOnly = true;
            this.grid_Pacientes.Size = new System.Drawing.Size(512, 299);
            this.grid_Pacientes.TabIndex = 0;
            // 
            // gbox_Conteudo
            // 
            this.gbox_Conteudo.Controls.Add(this.grid_Pacientes);
            this.gbox_Conteudo.Location = new System.Drawing.Point(831, 27);
            this.gbox_Conteudo.Name = "gbox_Conteudo";
            this.gbox_Conteudo.Size = new System.Drawing.Size(537, 331);
            this.gbox_Conteudo.TabIndex = 11;
            this.gbox_Conteudo.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(10, 26);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(40, 13);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Status:";
            // 
            // cbox_StatusPaciente
            // 
            this.cbox_StatusPaciente.Enabled = false;
            this.cbox_StatusPaciente.FormattingEnabled = true;
            this.cbox_StatusPaciente.Location = new System.Drawing.Point(53, 23);
            this.cbox_StatusPaciente.Name = "cbox_StatusPaciente";
            this.cbox_StatusPaciente.Size = new System.Drawing.Size(60, 21);
            this.cbox_StatusPaciente.TabIndex = 18;
            // 
            // lbl_Risco
            // 
            this.lbl_Risco.AutoSize = true;
            this.lbl_Risco.Location = new System.Drawing.Point(128, 26);
            this.lbl_Risco.Name = "lbl_Risco";
            this.lbl_Risco.Size = new System.Drawing.Size(82, 13);
            this.lbl_Risco.TabIndex = 22;
            this.lbl_Risco.Text = "Paciente Risco:";
            // 
            // lbl_Obito
            // 
            this.lbl_Obito.AutoSize = true;
            this.lbl_Obito.Location = new System.Drawing.Point(328, 26);
            this.lbl_Obito.Name = "lbl_Obito";
            this.lbl_Obito.Size = new System.Drawing.Size(38, 13);
            this.lbl_Obito.TabIndex = 23;
            this.lbl_Obito.Text = "Obito?";
            // 
            // cbox_Obito
            // 
            this.cbox_Obito.Enabled = false;
            this.cbox_Obito.FormattingEnabled = true;
            this.cbox_Obito.Location = new System.Drawing.Point(371, 23);
            this.cbox_Obito.Name = "cbox_Obito";
            this.cbox_Obito.Size = new System.Drawing.Size(51, 21);
            this.cbox_Obito.TabIndex = 24;
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
            this.gbox_Paciente.Controls.Add(this.cbbox_Convenio);
            this.gbox_Paciente.Location = new System.Drawing.Point(362, 18);
            this.gbox_Paciente.Name = "gbox_Paciente";
            this.gbox_Paciente.Size = new System.Drawing.Size(433, 88);
            this.gbox_Paciente.TabIndex = 25;
            this.gbox_Paciente.TabStop = false;
            this.gbox_Paciente.Text = "Dados Paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Status:";
            // 
            // cbox_StatusPessoa
            // 
            this.cbox_StatusPessoa.Enabled = false;
            this.cbox_StatusPessoa.FormattingEnabled = true;
            this.cbox_StatusPessoa.Location = new System.Drawing.Point(274, 63);
            this.cbox_StatusPessoa.Name = "cbox_StatusPessoa";
            this.cbox_StatusPessoa.Size = new System.Drawing.Size(60, 21);
            this.cbox_StatusPessoa.TabIndex = 25;
            // 
            // txtb_Risco
            // 
            this.txtb_Risco.Location = new System.Drawing.Point(213, 23);
            this.txtb_Risco.Name = "txtb_Risco";
            this.txtb_Risco.Size = new System.Drawing.Size(109, 20);
            this.txtb_Risco.TabIndex = 18;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.gbox_Conteudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbox_cadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_cadastro.ResumeLayout(false);
            this.gbox_cadastro.PerformLayout();
            this.gbox_Endereco.ResumeLayout(false);
            this.gbox_Endereco.PerformLayout();
            this.gbBox_rbTipoPessoa.ResumeLayout(false);
            this.gbBox_rbTipoPessoa.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pacientes)).EndInit();
            this.gbox_Conteudo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbox_Paciente.ResumeLayout(false);
            this.gbox_Paciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbox_Convenio;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.DataGridView grid_Pacientes;
        private System.Windows.Forms.GroupBox gbox_Conteudo;
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
    }
}

