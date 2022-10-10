select * from convenio;

select * from pessoa;

select * from paciente;

select * from endereco;

select * 
from pessoa p
join endereco e;

select pe.id as 
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
    inner join convenio c on pa.id_convenio = c.id;
    
