using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassPN
{
    public class PN : ConectaDb
    {
        public int idPn { get; set; }
        public String rsocial { get; set; }
        public String cnpj { get; set; }
        public String logradouro { get; set; }
        public Int32 num { get; set; }
        public String bairro { get; set; }
        public String cep { get; set; }
        public String complemento { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String pais { get; set; }
        public String email { get; set; }
        public DateTime dataCadastro { get; set; }


    }
}
