using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class VP
    {
        public Int32 id_venda { get; set; }
        public Int32 id_produto { get; set; }
        public Int32 status { get; set; }
        public Int32 id_compra { get; set; }
    }
}
