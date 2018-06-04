using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassColaborador
{
    public class Colaborador
    {
        public Int32 idColaborador { get; set; }
        public String nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public String sexo { get; set; }
        public Int32 ddd { get; set; }
        public Int32 tel { get; set; }
        public Int32 cel { get; set; }
        public String email { get; set; }
        public String logradouro { get; set; }
        public Int32 num { get; set; }
        public String bairro { get; set; }
        public String cep { get; set; }
        public String complemento { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String pais { get; set; }
        public String cpf { get; set; }
        public String rg { get; set; }
        public String ctps { get; set; }
        public String pis { get; set; }
        public DateTime dataContratacao { get; set; }
        public Int32 idSetor { get; set; }
        public Double salario { get; set; }
    }
}
