using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Trener : Osoba
    {
         string _specijalizacija { get; set; }
         int _godineIskustva { get; set; }
         List<Igrac> _listaIgraca { get; set; }
         int _br { get; set; }
         Igrac _igrac { get; set; }

        public Trener()
        {
            Console.Write("Unesite specijalizaciju: ");
            _specijalizacija = Console.ReadLine();
            Console.Write("Unesite godine iskustva: ");
            _godineIskustva = int.Parse(Console.ReadLine());
            _listaIgraca = new List<Igrac>();
            Console.Write("Unesite broj igraca: ");
            _br = int.Parse(Console.ReadLine());
            for (int i = 0; i < _br; i++)
            {
                Console.Write($"Unesite ime {i + 1}. igraca: ");
                string imeIgraca = Console.ReadLine();
                _igrac = new Igrac { Ime = imeIgraca };
                _listaIgraca.Add(_igrac);
            }
        }

        public void DodajIgraca()
        {
            Console.Write("Unesite ime igraca: ");
            string imeIgraca = Console.ReadLine();
            _igrac = new Igrac { Ime = imeIgraca };
            _listaIgraca.Add(_igrac);
            _br++;
        }

        public void UkloniIgraca()
        {
            Console.Write("Unesite ime igraca za uklanjanje: ");
            string imeIgraca = Console.ReadLine();
            var igracZaUklanjanje = _listaIgraca.FirstOrDefault(igrac => igrac.Ime == imeIgraca);
            if (igracZaUklanjanje != null)
            {
                _listaIgraca.Remove(igracZaUklanjanje);
                _br--;
            }
            else
            {
                Console.WriteLine("Igrac nije pronadjen.");
            }
        }

        public Igrac NajviseGolova()
        {
            Igrac najboljiIgrac = null;
            int maxGolova = -1;
            foreach (var igrac in _listaIgraca)
            {
                if (igrac._brojPostignutihGolova > maxGolova)
                {
                    maxGolova = igrac._brojPostignutihGolova;
                    najboljiIgrac = igrac;
                }
            }
            return najboljiIgrac;
        }

        pubic double prosjekGolova()
        {
            double prosjek = 0;
            int ukupnoGolova = 0;
            foreach (var igrac in _listaIgraca)
            {
                prosjek += igrac._brojPostignutihGolova;

            }
            if (_br > 0)
            {
                prosjek=prosjek / _br;
            }
            return prosjek;

        }

        public void UkupnoGolovi()
        {
                       int ukupnoGolova = 0;
            foreach (var igrac in _listaIgraca)
            {
                ukupnoGolova += igrac._brojPostignutihGolova;
            }
            Console.WriteLine($"Ukupno postignutih golova: {ukupnoGolova}");

        }
    }
}
