using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_Sharp.Models
{
    public class PacienteModel
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public DateTime nascimento { get; set; }
        public string endereco { get; set; }
        public DateTime dataConsulta { get; set; }
    }
}
