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
using System.Windows.Media.TextFormatting;

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
            var listPessoas = PacienteRepository.GetAllPessoas();
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
                //paciente.Pessoa.Id = Int32.Parse(txtb_idAlteracao.Text);
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
                }
                else if (rb_Alterar.Checked)
                {
                    paciente.Status = (FlStatus)cbox_StatusPessoa.SelectedItem;
                    Int32 idBuscar = Int32.Parse(txtb_idAlteracao.Text);
                    var pacienteResult = PacienteRepository.UpdatePessoa(paciente, Int32.Parse(txtb_idAlteracao.Text), conn);
                    endereco.Pessoa = paciente.Pessoa;
                    var enderecoResult = EnderecoRepository.UpdateEndereco(endereco, conn);
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
            cbox_StatusPessoa.Enabled = false;
            cbox_StatusPaciente.Enabled = false;
            cbox_Obito.Enabled = false;
            masktxtb_CGCCPF.Enabled = true;
            rbFisica.Enabled = true;
            rbJuridica.Enabled = true;
            lbl_IdAlterar.Visible = false;
        }

        private void rb_Alterar_CheckedChanged(object sender, EventArgs e)
        {
            txtb_idAlteracao.Visible = true;
            txtb_idAlteracao.Enabled = true;
            btn_BuscaPaciente.Visible = true;
            cbox_StatusPessoa.Enabled = true;
            cbox_StatusPaciente.Enabled = true;
            cbox_Obito.Enabled = true;
            masktxtb_CGCCPF.Enabled = false;
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;
            lbl_IdAlterar.Visible = true;
        }
        
        private void btn_BuscaPaciente_Click(object sender, EventArgs e)
        {
            Int32 idBuscar = Int32.Parse(txtb_idAlteracao.Text);
            var pacienteData = PacienteRepository.GetPaciente(idBuscar);
            pacienteData.Read();
            var pessoaData = PacienteRepository.GetPessoa(Int32.Parse(pacienteData.GetString("id_pessoa")));
            pessoaData.Read();
            var enderecoData = EnderecoRepository.GetEndereco(Int32.Parse(pacienteData.GetString("id_pessoa")));
            enderecoData.Read();
            var convenioData = ConvenioRepository.FetchAll();

            txtb_Nome.Text = pessoaData.GetString("nome");
            masktxtb_CGCCPF.Text = pessoaData.GetString("cgccpf");
            cbox_StatusPessoa.Text = pessoaData.GetString("fl_status");
            masktxtb_CEP.Text = enderecoData.GetString("CEP");
            cbox_UF.Text = enderecoData.GetString("uf");
            txtb_Cidade.Text = enderecoData.GetString("cidade");
            txtb_Bairro.Text = enderecoData.GetString("bairro");
            txtb_Rua.Text = enderecoData.GetString("rua");
            txtb_Numero.Text = enderecoData.GetString("numero");
            cbox_StatusPaciente.Text = pacienteData.GetString("fl_status");
            txtb_Risco.Text = pacienteData.GetString("paciente_risco");
            cbox_Obito.Text = pacienteData.GetString("fl_obito");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Sistema Cadastro +Devs2Blu V1.0 \n-Alexandre Schanke da Costa");
        }

        private void ibtnListPaciente_Click(object sender, EventArgs e)
        {
            grid_Pacientes.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema Hospital para Cadastro de Pacientes.");
        }

        private void ibtnSalvar_Click(object sender, EventArgs e)
        {
            CadastraAlteraPaciente();
            
        }
        private void ibtnLimpar_Click(object sender, EventArgs e)
        {
            txtb_Nome.Text = "";
            masktxtb_CGCCPF.Text = "___.___.___-__";
            cbox_StatusPessoa.Text = "";
            masktxtb_CEP.Text = "__.___-__";
            cbox_UF.Text = "";
            txtb_Cidade.Text = "";
            txtb_Bairro.Text = "";
            txtb_Rua.Text = "";
            txtb_Numero.Text = "";
            cbox_StatusPaciente.Text = "";
            txtb_Risco.Text = "";
            cbox_Convenio.Text = "";
            cbox_Obito.Text = "";
            txtb_idExcluir.Text = "";
            txtb_idAlteracao.Text = "";
            rb_Cadastrar.Checked = true;

            /* txtb_Nome.Clear();
             masktxtb_CGCCPF.Clear();
             cbox_StatusPessoa.Text = "";
             masktxtb_CEP.Clear();
             cbox_UF.Text = "";
             txtb_Cidade.Clear();
             txtb_Bairro.Clear();
             txtb_Rua.Clear();
             txtb_Numero.Clear();
             cbox_StatusPaciente.Text = "";
             txtb_Risco.Clear();
             cbox_Convenio.Text = "";
             cbox_Obito.Text = "";
             txtb_idExcluir.Clear();
             txtb_idAlteracao.Clear();
             rb_Cadastrar.Checked = true;*/

        }
        private void ibtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro Hospitalar de Pacientes");
        }
        private void ibtnInfo_MouseHover(object sender, EventArgs e)
        {
           
            ibtnInfo.BackColor = Color.DarkTurquoise;
        }
        private void ibtnInfo_MouseLeave(object sender, EventArgs e)
        {

            ibtnInfo.BackColor = Color.White;
        }
        private void ibtnSalvar_MouseHover(object sender, EventArgs e)
        {
            ibtnSalvar.BackColor = Color.DarkTurquoise;
        }

        private void ibtnSalvar_MouseLeave(object sender, EventArgs e)
        {
            ibtnSalvar.BackColor = Color.White;
        }

        private void ibtnLimpar_MouseHover(object sender, EventArgs e)
        {
            ibtnLimpar.BackColor = Color.DarkTurquoise;
        }

        private void ibtnLimpar_MouseLeave(object sender, EventArgs e)
        {
            ibtnLimpar.BackColor = Color.White;
        }

        private void ibtnListPaciente_MouseHover(object sender, EventArgs e)
        {
            ibtnListPaciente.BackColor = Color.DarkTurquoise;
        }

        private void ibtnListPaciente_MouseLeave(object sender, EventArgs e)
        {
            ibtnListPaciente.BackColor = Color.White;
        }

        #endregion


    }
}
