using Devs2Blu.Projetos.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.Projetos.SistemaCadastro.Forms.Data
{
    public class PacienteRepository
    {
        public Paciente Save(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                paciente.Pessoa.Id = SavePessoa(paciente, conn);
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);

                cmd.Parameters.Add(@"id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add(@"id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
                cmd.Parameters.Add(@"numero_prontuario", MySqlDbType.Int32).Value = paciente.NrProntuario;
                cmd.Parameters.Add(@"paciente_risco", MySqlDbType.VarChar, 10).Value = paciente.PacienteRisco;
                //cmd.Parameters.Add(@"fl_status", MySqlDbType.Int64).Value = paciente.Status;
                //cmd.Parameters.Add(@"fl_obito", MySqlDbType.Int64).Value = paciente.FlObito;
                cmd.ExecuteNonQuery();

                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Ocorreu um erro no MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTES, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SavePessoa(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 55).Value = paciente.Pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 18).Value = paciente.Pessoa.CGCCPF;
                cmd.Parameters.Add("@tipo_pessoa", MySqlDbType.Enum).Value = paciente.Pessoa.TipoPessoa;
                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Ocorreu um erro no MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs

        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
(nome,
cgccpf,
tipo_pessoa,
fl_status)
VALUES
(@nome,
@cgccpf,
@tipo_pessoa,
'A')";
        private const String SQL_SELECT_PESSOAS = @"SELECT id, nome, cgccpf, fl_status from pessoa";
        private const String SQL_SELECT_PACIENTES = @"select pe.id as 
	Id_Pessoa, 
	pa.id as Id_Paciente, 
	pe.fl_status as 'Status', 
	pe.nome as Nome, 
	pe.cgccpf as CPF, 
	pa.numero_prontuario as N_Prontuário, 
	pa.paciente_risco as Risco, 
	c.nome as Convenio 
from paciente pa
	inner join pessoa pe on pa.id_pessoa = pe.id
    inner join convenio c on pa.id_convenio = c.id;";
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
(id_pessoa,
id_convenio,
numero_prontuario,
paciente_risco,
fl_status,
fl_obito)
VALUES
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@paciente_risco,
'A',
0)";
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
(id_pessoa,
CEP,
rua,
numero,
bairro,
cidade,
uf)
VALUES
(@id_Pessoa,
@CEP,
@rua,
@numero,
@bairro,
@cidade,
@uf)";

        #endregion
    }
}
