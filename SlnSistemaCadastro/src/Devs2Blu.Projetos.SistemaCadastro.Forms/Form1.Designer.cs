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
            this.cbBoxConvenio = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.gbBox_rbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.llbNome = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbBox_rbTipoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxConvenio
            // 
            this.cbBoxConvenio.FormattingEnabled = true;
            this.cbBoxConvenio.Location = new System.Drawing.Point(93, 29);
            this.cbBoxConvenio.Name = "cbBoxConvenio";
            this.cbBoxConvenio.Size = new System.Drawing.Size(192, 21);
            this.cbBoxConvenio.TabIndex = 0;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(21, 32);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(52, 13);
            this.lblConvenio.TabIndex = 1;
            this.lblConvenio.Text = "Convênio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCGCCPF);
            this.groupBox1.Controls.Add(this.llbNome);
            this.groupBox1.Controls.Add(this.gbBox_rbTipoPessoa);
            this.groupBox1.Controls.Add(this.lblConvenio);
            this.groupBox1.Controls.Add(this.cbBoxConvenio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Cadastro";
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Location = new System.Drawing.Point(16, 24);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 3;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // gbBox_rbTipoPessoa
            // 
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbJuridica);
            this.gbBox_rbTipoPessoa.Controls.Add(this.rbFisica);
            this.gbBox_rbTipoPessoa.Location = new System.Drawing.Point(14, 65);
            this.gbBox_rbTipoPessoa.Name = "gbBox_rbTipoPessoa";
            this.gbBox_rbTipoPessoa.Size = new System.Drawing.Size(169, 55);
            this.gbBox_rbTipoPessoa.TabIndex = 3;
            this.gbBox_rbTipoPessoa.TabStop = false;
            this.gbBox_rbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(92, 24);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 4;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // llbNome
            // 
            this.llbNome.AutoSize = true;
            this.llbNome.Location = new System.Drawing.Point(21, 138);
            this.llbNome.Name = "llbNome";
            this.llbNome.Size = new System.Drawing.Size(35, 13);
            this.llbNome.TabIndex = 4;
            this.llbNome.Text = "Nome";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(21, 170);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(49, 13);
            this.lblCGCCPF.TabIndex = 5;
            this.lblCGCCPF.Text = "CGCCPF";
            this.lblCGCCPF.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBox_rbTipoPessoa.ResumeLayout(false);
            this.gbBox_rbTipoPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label llbNome;
        private System.Windows.Forms.GroupBox gbBox_rbTipoPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
    }
}

