using Devs2Blu.Projetos.SistemaCadastro.Forms.Data;
using Devs2Blu.Projetos.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projetos.SistemaCadastro.Forms
{
    public partial class FormMain : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();

        public FormMain()
        {
            InitializeComponent();
        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();

            cbbox_Convenio.DataSource = new BindingSource(listConvenios, null);
            cbbox_Convenio.DisplayMember = "nome";
            cbbox_Convenio.ValueMember = "id";
        }

        private bool ValidaFormCadastro()
        {
            if (txtb_Nome.Text.Equals("")) { return false; }
            if (masktxtb_CGCCPF.Text.Equals("")) { return false; }
            //if (cbbox_Convenio.SelectedIndex.Equals(-1)) { return false; }
            //if (masktxtb_CEP.Text.Equals("")) { return false; }
            //if (cbbox_UF.SelectedIndex.Equals(-1)) { return false; }
            //if (txtb_Cidade.Text.Equals("")) { return false; }
            //if (txtb_Bairro.Text.Equals("")) { return false; }
            //if (txtb_Rua.Text.Equals("")) { return false; }
            //if (txtb_Numero.Text.Equals("")) { return false; }

            return true;
        }

        #endregion

        #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            //Conn = ConnectionMySQL.GetConnection();

            //if (Conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    Conn.Close();
            //}
            #endregion
            PopulaComboConvenio();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                lblCGCCPF.Text = "CPF";
                lblCGCCPF.Visible = true;
            }
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJuridica.Checked)
            {
                lblCGCCPF.Text = "CNPJ";
                lblCGCCPF.Visible = true;
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Paciente paciente = new Paciente();
                paciente.Pessoa.Nome = txtb_Nome.Text;
                paciente.Pessoa.CGCCPF = masktxtb_CGCCPF.Text;
                paciente.Convenio.Id = (int)cbbox_Convenio.SelectedValue;
                var pacienteResult = PacienteRepository.Save(paciente);
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salvo com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion
    }
}
