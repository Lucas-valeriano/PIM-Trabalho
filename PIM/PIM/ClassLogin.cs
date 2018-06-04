using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    public class ClassLogin : ConectaDb
    {
        public String nome { get; set; }
        public String senha { get; set; }
    }
}