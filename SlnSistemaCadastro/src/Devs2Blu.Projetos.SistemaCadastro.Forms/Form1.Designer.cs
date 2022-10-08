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
            this.gb_cadastro = new System.Windows.Forms.GroupBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masktxtb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txtb_Numero = new System.Windows.Forms.TextBox();
            this.txtb_Rua = new System.Windows.Forms.TextBox();
            this.txtb_Bairro = new System.Windows.Forms.TextBox();
            this.txtb_Cidade = new System.Windows.Forms.TextBox();
            this.cbbox_UF = new System.Windows.Forms.ComboBox();
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
            this.grid_Paciente = new System.Windows.Forms.DataGridView();
            this.gbox_Conteudo = new System.Windows.Forms.GroupBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masktxtb_CGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.gb_cadastro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbBox_rbTipoPessoa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Paciente)).BeginInit();
            this.gbox_Conteudo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbox_Convenio
            // 
            this.cbbox_Convenio.FormattingEnabled = true;
            this.cbbox_Convenio.Location = new System.Drawing.Point(79, 39);
            this.cbbox_Convenio.Name = "cbbox_Convenio";
            this.cbbox_Convenio.Size = new System.Drawing.Size(90, 21);
            this.cbbox_Convenio.TabIndex = 0;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(21, 42);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(55, 13);
            this.lblConvenio.TabIndex = 1;
            this.lblConvenio.Text = "Convênio:";
            // 
            // gb_cadastro
            // 
            this.gb_cadastro.Controls.Add(this.masktxtb_CGCCPF);
            this.gb_cadastro.Controls.Add(this.btn_Cadastrar);
            this.gb_cadastro.Controls.Add(this.groupBox2);
            this.gb_cadastro.Controls.Add(this.btn_Limpar);
            this.gb_cadastro.Controls.Add(this.txtb_Nome);
            this.gb_cadastro.Controls.Add(this.lblCGCCPF);
            this.gb_cadastro.Controls.Add(this.llbNome);
            this.gb_cadastro.Controls.Add(this.gbBox_rbTipoPessoa);
            this.gb_cadastro.Controls.Add(this.lblConvenio);
            this.gb_cadastro.Controls.Add(this.cbbox_Convenio);
            this.gb_cadastro.Location = new System.Drawing.Point(12, 29);
            this.gb_cadastro.Name = "gb_cadastro";
            this.gb_cadastro.Size = new System.Drawing.Size(356, 309);
            this.gb_cadastro.TabIndex = 2;
            this.gb_cadastro.TabStop = false;
            this.gb_cadastro.Text = "Formulário de Cadastro";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(10, 264);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(248, 36);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.masktxtb_CEP);
            this.groupBox2.Controls.Add(this.txtb_Numero);
            this.groupBox2.Controls.Add(this.txtb_Rua);
            this.groupBox2.Controls.Add(this.txtb_Bairro);
            this.groupBox2.Controls.Add(this.txtb_Cidade);
            this.groupBox2.Controls.Add(this.cbbox_UF);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço / Contato";
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
            this.txtb_Numero.Location = new System.Drawing.Point(254, 81);
            this.txtb_Numero.Name = "txtb_Numero";
            this.txtb_Numero.Size = new System.Drawing.Size(63, 20);
            this.txtb_Numero.TabIndex = 17;
            // 
            // txtb_Rua
            // 
            this.txtb_Rua.Location = new System.Drawing.Point(53, 81);
            this.txtb_Rua.Name = "txtb_Rua";
            this.txtb_Rua.Size = new System.Drawing.Size(147, 20);
            this.txtb_Rua.TabIndex = 16;
            // 
            // txtb_Bairro
            // 
            this.txtb_Bairro.Location = new System.Drawing.Point(216, 52);
            this.txtb_Bairro.Name = "txtb_Bairro";
            this.txtb_Bairro.Size = new System.Drawing.Size(101, 20);
            this.txtb_Bairro.TabIndex = 15;
            // 
            // txtb_Cidade
            // 
            this.txtb_Cidade.Location = new System.Drawing.Point(53, 52);
            this.txtb_Cidade.Name = "txtb_Cidade";
            this.txtb_Cidade.Size = new System.Drawing.Size(116, 20);
            this.txtb_Cidade.TabIndex = 14;
            // 
            // cbbox_UF
            // 
            this.cbbox_UF.FormattingEnabled = true;
            this.cbbox_UF.Location = new System.Drawing.Point(216, 23);
            this.cbbox_UF.Name = "cbbox_UF";
            this.cbbox_UF.Size = new System.Drawing.Size(101, 21);
            this.cbbox_UF.TabIndex = 8;
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
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
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
            this.btn_Limpar.Location = new System.Drawing.Point(264, 264);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(82, 36);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Location = new System.Drawing.Point(79, 74);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(256, 20);
            this.txtb_Nome.TabIndex = 6;
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(21, 110);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCGCCPF.TabIndex = 5;
            this.lblCGCCPF.Text = "CPF:";
            // 
            // llbNome
            // 
            this.llbNome.AutoSize = true;
            this.llbNome.Location = new System.Drawing.Point(21, 77);
            this.llbNome.Name = "llbNome";
            this.llbNome.Size = new System.Drawing.Size(38, 13);
            this.llbNome.TabIndex = 4;
            this.llbNome.Text = "Nome:";
            // 
            // gbBox_rbTipoPessoa
            // 
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbJuridica);
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbFisica);
            this.gbBox_rbTipoPessoa.Location = new System.Drawing.Point(189, 13);
            this.gbBox_rbTipoPessoa.Name = "gbBox_rbTipoPessoa";
            this.gbBox_rbTipoPessoa.Size = new System.Drawing.Size(146, 49);
            this.gbBox_rbTipoPessoa.TabIndex = 3;
            this.gbBox_rbTipoPessoa.TabStop = false;
            this.gbBox_rbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(75, 18);
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
            this.rbFisica.Location = new System.Drawing.Point(12, 18);
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
            this.panel1.Size = new System.Drawing.Size(776, 65);
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
            // grid_Paciente
            // 
            this.grid_Paciente.AllowUserToAddRows = false;
            this.grid_Paciente.AllowUserToOrderColumns = true;
            this.grid_Paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Paciente.Location = new System.Drawing.Point(15, 19);
            this.grid_Paciente.Name = "grid_Paciente";
            this.grid_Paciente.ReadOnly = true;
            this.grid_Paciente.Size = new System.Drawing.Size(375, 297);
            this.grid_Paciente.TabIndex = 0;
            // 
            // gbox_Conteudo
            // 
            this.gbox_Conteudo.Controls.Add(this.grid_Paciente);
            this.gbox_Conteudo.Location = new System.Drawing.Point(384, 29);
            this.gbox_Conteudo.Name = "gbox_Conteudo";
            this.gbox_Conteudo.Size = new System.Drawing.Size(404, 331);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masktxtb_CGCCPF
            // 
            this.masktxtb_CGCCPF.Location = new System.Drawing.Point(79, 107);
            this.masktxtb_CGCCPF.Name = "masktxtb_CGCCPF";
            this.masktxtb_CGCCPF.Size = new System.Drawing.Size(131, 20);
            this.masktxtb_CGCCPF.TabIndex = 18;
            this.masktxtb_CGCCPF.Text = "___.___.___-__";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_Conteudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_cadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_cadastro.ResumeLayout(false);
            this.gb_cadastro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBox_rbTipoPessoa.ResumeLayout(false);
            this.gbBox_rbTipoPessoa.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Paciente)).EndInit();
            this.gbox_Conteudo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbox_Convenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.GroupBox gb_cadastro;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label llbNome;
        private System.Windows.Forms.GroupBox gbBox_rbTipoPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.ComboBox cbbox_UF;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.MaskedTextBox masktxtb_CEP;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.DataGridView grid_Paciente;
        private System.Windows.Forms.GroupBox gbox_Conteudo;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MaskedTextBox masktxtb_CGCCPF;
    }
}

