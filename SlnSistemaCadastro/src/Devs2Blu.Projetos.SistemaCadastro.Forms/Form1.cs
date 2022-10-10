using Devs2Blu.Projetos.SistemaCadastro.Forms.Data;
using Devs2Blu.Projetos.SistemaCadastro.Models.Enum;
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
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();

        public FormMain()
        {
            InitializeComponent();
        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();

            cbox_Convenio.DataSource = new BindingSource(listConvenios, null);
            cbox_Convenio.DisplayMember = "nome";
            cbox_Convenio.ValueMember = "id";
        }

        private void PopulaComboStatus()
        {
            cbox_StatusPessoa.DataSource = Enum.GetValues(typeof(FlStatus));
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoas = PacienteRepository.GetPessoas();
            grid_Pacientes.DataSource = new BindingSource(listPessoas, null);
        }

        private bool ValidaFormCadastro()
        {
            if (txtb_Nome.Text.Equals("")) { return false; }
            if (masktxtb_CGCCPF.Text.Equals("")) { return false; }
            if (cbox_Convenio.SelectedIndex.Equals(-1)) { return false; }
            if (txtb_Risco.Text.Equals("")) { return false; }
            if (masktxtb_CEP.Text.Equals("")) { return false; }
            if (cbox_UF.SelectedIndex.Equals(-1)) { return false; }
            if (txtb_Cidade.Text.Equals("")) { return false; }
            if (txtb_Bairro.Text.Equals("")) { return false; }
            if (txtb_Rua.Text.Equals("")) { return false; }
            if (txtb_Numero.Text.Equals("")) { return false; }

            return true;
        }

        private Int32 geraProntuario()
        {
            Random rd = new Random();
            Int32 nrProntuario = Int32.Parse($"{rd.Next(10000, 99999)}{DateTime.Now.Second + 10}");
            return nrProntuario;
        }

        private void CadastraAlteraPaciente()
        {
            if (ValidaFormCadastro())
            {
                Paciente paciente = new Paciente();
                Endereco endereco = new Endereco();
                paciente.Pessoa.Nome = txtb_Nome.Text;
                paciente.Pessoa.CGCCPF = masktxtb_CGCCPF.Text;
                paciente.Convenio.Id = (int)cbox_Convenio.SelectedValue;
                paciente.PacienteRisco = txtb_Risco.Text;
                paciente.NrProntuario = geraProntuario();
                paciente.TipoPessoa = rbFisica.Checked ? TipoPessoa.PF : TipoPessoa.PF;

                endereco.CEP = masktxtb_CEP.Text;
                endereco.UF = cbox_UF.Text;
                endereco.Cidade = txtb_Cidade.Text;
                endereco.Bairro = txtb_Bairro.Text;
                endereco.Rua = txtb_Rua.Text;
                endereco.Numero = Int32.Parse(txtb_Numero.Text);

                MySqlConnection conn = ConnectionMySQL.GetConnection();
                if (rb_Cadastrar.Checked)
                {
                    var pacienteResult = PacienteRepository.Save(paciente, conn);
                    endereco.Pessoa = paciente.Pessoa;
                    var enderecoResult = EnderecoRepository.SaveEndereco(endereco, conn);
                    if (pacienteResult.Pessoa.Id > 0)
                    {
                        MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salvo com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PopulaDataGridPessoa();
                    }
                } else if (rb_Alterar.Checked)
                {
                    paciente.Status = (FlStatus)cbox_StatusPessoa.SelectedItem;
                    var pacienteResult = PacienteRepository.Update(paciente, Int32.Parse(txtb_idAlteracao.Text), conn);
                    endereco.Pessoa = paciente.Pessoa;
                    //var enderecoResult = EnderecoRepository.UpdateEndereco(endereco, conn);
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salvo com sucesso!", "Alteração de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }
                
            }
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
            PopulaDataGridPessoa();
            PopulaComboStatus();
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
            CadastraAlteraPaciente();
        }

        private void btn_Exluir_Click(object sender, EventArgs e)
        {
            Int32 idBuscar = Int32.Parse(txtb_idExcluir.Text);
            var pacienteData = PacienteRepository.GetPaciente(idBuscar);
            pacienteData.Read();
            EnderecoRepository.ExcluirEndereco(Int32.Parse(pacienteData.GetString("id_pessoa")));
            PacienteRepository.ExcluirPaciente(Int32.Parse(pacienteData.GetString("id_pessoa")), Int32.Parse(pacienteData.GetString("id")));
            PopulaDataGridPessoa();
        }

        private void rb_Cadastrar_CheckedChanged(object sender, EventArgs e)
        {
            txtb_idAlteracao.Visible = false;
            txtb_idAlteracao.Enabled = false;
            btn_BuscaPaciente.Visible = false;
        }

        private void rb_Alterar_CheckedChanged(object sender, EventArgs e)
        {
            txtb_idAlteracao.Visible = true;
            txtb_idAlteracao.Enabled = true;
            btn_BuscaPaciente.Visible = true;
        }
        
        private void btn_BuscaPaciente_Click(object sender, EventArgs e)
        {
            Int32 idBuscar = Int32.Parse(txtb_idAlteracao.Text);
            var pacienteData = PacienteRepository.GetPaciente(idBuscar);
            pacienteData.Read();
            MessageBox.Show($"{pacienteData.GetString("id")}");
        }

        #endregion

    }
}
