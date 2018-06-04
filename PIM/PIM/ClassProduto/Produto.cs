using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassProduto
{
    public class Produto
    {
        public Int32 idPro { get; set; }
        public String marca { get; set; }
        public String nome { get; set; }
        public Int32 qtd { get; set; }
        public Int32 qtdMin { get; set; }
        public Int32 codigo { get; set; }
        public Double valor { get; set; }
        public Double desconto { get; set; }
        public String foto { get; set; }
        public String cor { get; set; }
        public String tamanho { get; set; }
        public DateTime dataCadastro { get; set; }
        

    }
}
