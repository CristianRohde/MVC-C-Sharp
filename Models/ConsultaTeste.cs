using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_Sharp.Models
{
    public class ConsultaTeste
    {
        public List<PacienteModel> listaPaciente = new List<PacienteModel>();
        public ConsultaTeste()
        {
            listaPaciente.Add(new PacienteModel
            {
                id = "01",
                nome = "Sandra",
                sobrenome = "Roler",
                email = "sandra@gmail.com",
                nascimento = Convert.ToDateTime("14/12/1988"),
                endereco = "Rua Alcaras 1",
                dataConsulta = Convert.ToDateTime("07/08/2019")
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
    }
}
