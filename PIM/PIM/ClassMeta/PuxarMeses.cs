using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassMeta
{
    public class PuxarMeses
    {
        List<Meses> m = new List<Meses>();
        public List<Meses> PuxandoMeses()
        {
            for ( int i = 0; i <= 11; i++)
            {
                Meses mes = new Meses();
                mes.mes = i + 1;
                m.Add(mes);
            }
            return m;
        }
    }
}
