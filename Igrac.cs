using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Igrac:Osoba
    {
        string _pozicija { get; set; }
         int _brojDresa { get; set; }
         int _brojPostignutihGolova { get; set; }
         List<string> _listaUtakmica { get; set; }
         int _br { get; set; }
         string _utakmica { get; set; }

        public Igrac()
        {
            Console.Write("Unesite poziciju: ");
            _pozicija = Console.ReadLine();
            Console.Write("Unesite broj dresa: ");
            _brojDresa = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj postignutih golova: ");
            _brojPostignutihGolova = int.Parse(Console.ReadLine());
            _listaUtakmica = new List<string>();
            Console.Write("Unesite broj utakmica: ");
            _br = int.Parse(Console.ReadLine());

            for (int i = 0; i < _br; i++)
            {
                Console.Write("Unesite naziv {i + 1}. utakmice: ");
                _utakmica = Console.ReadLine();
                _listaUtakmica.Add(utakmica);
            }
        }
    }
}
