using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassCliente
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public String nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public String sexo { get; set; }
        public String email { get; set; }
        public String logradouro { get; set; }
        public Int32 numero { get; set; }
        public String bairro { get; set; }
        public String cep { get; set; }
        public String complemento { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String pais { get; set; }
        public String cpf { get; set; }
        public String rg { get; set; }
        public DateTime data_cadastro { get; set; }
        public Int32 ddd { get; set; }
        public Int32 telefone { get; set; }
        public Int32 celular { get; set; }
    }
}
