using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class Venda
    {
        public Int32 id_venda { get; set; }
        public Int32 id_vendedor { get; set; }
        public Int32 id_comprador { get; set; }
        public String data { get; set; }
        public String comp { get; set; }
    }
}
