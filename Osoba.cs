using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Osoba
    {
        protected string _ime { get; set; }
        protected string _prezime { get; set; }
        protected DateTime _datumRodjenja { get; set; }
        protected string _maticniBroj { get; set; }

        public Osoba()
        {
            Console.Write("Unesite ime: ");
            _ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            _prezime = Console.ReadLine();
            Console.Write("Unesite datum rodjenja (dd.MM.yyyy): ");
            _datumRodjenja = DateTime.Parse(Console.ReadLine());
            Console.Write("Unesite maticni broj: ");
            _maticniBroj = Console.ReadLine();
        }

    }
}
