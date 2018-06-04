using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassMeta
{
    public class ValorComissao
    {

        List<Comissao> com = new List<Comissao>();
        public List<Comissao> PuxaComissao()
        {
            for (int i = 1; i <= 5; i++)
            {
                Comissao c = new Comissao();
                c.porcentagem = i * 5;
                com.Add(c);
            }
            return com;
        }
    }
}
