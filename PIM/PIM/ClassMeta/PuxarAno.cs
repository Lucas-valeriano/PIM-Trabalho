using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassMeta
{
    public class PuxarAno
    {
        List<Ano> a = new List<Ano>();

        public List<Ano> PuxeAno()
        {
            for(int i = 0; i<=1; i++)
            {
                Ano ano = new Ano();
                ano.ano = DateTime.Now.Year + i;
                a.Add(ano);
            }
            
            return a;
        }
    }
}
