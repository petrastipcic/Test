using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Utakmica
    {
        protected DateTime _datum { get; set; }
        protected string _protivnik { get; set; }
        protected int _postignutiGolovi { get; set; }
        protected int _primljeniGolovi { get; set; }
        Console.Write("Unesite datum utakmice (dd.MM.yyyy): ");
            _datum = DateTime.Parse(Console.ReadLine());
            Console.Write("Unesite naziv protivnika: ");
            _protivnik = Console.ReadLine();
            Console.Write("Unesite broj postignutih golova: ");
            _postignutiGolovi = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj primljenih golova: ");
            _primljeniGolovi = int.Parse(Console.ReadLine());
    }
}
