using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Trener:Osoba 
    {
        protected string _specijalizacija { get; set; }
        protected int _godineIskustva { get; set; }
        protected List<string> _listaIgraca { get; set; }
    }
}
