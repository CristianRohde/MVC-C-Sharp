using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_Sharp.Models
{
    public class PacienteTeste
    {
        public List<PacienteModel> listaPaciente = new List<PacienteModel>();
        public PacienteTeste()
        {
            listaPaciente.Add(new PacienteModel
            {
                id = "01",
                nome = "Sandra",
                sobrenome = "Roler",
                email = "sandra@gmail.com",
                nascimento = Convert.ToDateTime("14/12/1988"),
                endereco = "Rua Alcaras 1",
                dataConsulta = Convert.ToDateTime(null)
            });
            listaPaciente.Add(new PacienteModel
            {
                id = "02",
                nome = "Alexa",
                sobrenome = "Beber",
                email = "alexa@gmail.com",
                nascimento = Convert.ToDateTime("28/02/1901"),
                endereco = "Rua Sumba",
                dataConsulta = Convert.ToDateTime("14/11/2019")
            });
            listaPaciente.Add(new PacienteModel
            {
                id = "03",
                nome = "Catalina",
                sobrenome = "Jazz",
                email = "cata@gmail.com",
                nascimento = Convert.ToDateTime("15/10/1995"),
                endereco = "Rua transito 2",
                dataConsulta = Convert.ToDateTime("24/05/2019")
            });
            listaPaciente.Add(new PacienteModel
            {
                id = "04",
                nome = "Mara",
                sobrenome = "Roye",
                email = "mara@gmail.com",
                nascimento = Convert.ToDateTime("01/02/1988"),
                endereco = "Rua Noni 4",
                dataConsulta = Convert.ToDateTime("03/05/2019")
            });
        }
        // CRIANDO NOVO PACIENTE
        public void CriaPaciente(PacienteModel pacienteModel)
        {
            listaPaciente.Add(pacienteModel);
        }
        // ATUALIZANDO PACIENTE
        public void AtualizaPaciente(PacienteModel pacienteModel)
        {
            foreach (PacienteModel p in listaPaciente.ToList<PacienteModel>())
            {
                if (p.nome == pacienteModel.nome && p.sobrenome == pacienteModel.sobrenome)
                {
                    listaPaciente.Remove(p);
                    listaPaciente.Add(pacienteModel);
                }
            }
        }
        // GET PACIENTE
        public PacienteModel GetPaciente(string Id)
        {
            PacienteModel p = null;
            foreach (PacienteModel paciente in listaPaciente)
            {
                if (paciente.id == Id)
                {
                    p = paciente;
                }
            }
            return p;
        }
        // DELETA PACIENTE
        public void DeletaPaciente(string Id)
        {
            foreach (PacienteModel paciente in listaPaciente)
            {
                if (paciente.id == Id)
                {
                    listaPaciente.Remove(paciente);
                    break;
                }
            }
        }
        // MARCA CONSULTA DE PACIENTE
        public void MarcaConsulta(PacienteModel paciente)
        {
            foreach(PacienteModel p in listaPaciente.ToList<PacienteModel>())
            {
                if(p.nome == paciente.nome && p.sobrenome == paciente.sobrenome)
                {
                    listaPaciente.Add(paciente);
                }
            }
        }
    }
}
