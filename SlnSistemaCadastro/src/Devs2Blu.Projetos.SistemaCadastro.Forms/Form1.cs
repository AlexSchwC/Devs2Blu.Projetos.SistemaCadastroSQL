using Devs2Blu.Projetos.SistemaCadastro.Forms.Data;
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
        public FormMain()
        {
            InitializeComponent();
        }

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

        #endregion

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();

            while (listConvenios.Read())
            {
                cbBoxConvenio.Items.Add(listConvenios.GetString("nome"));
            }
        }

        #endregion

    }
}
