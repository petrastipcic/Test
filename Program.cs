using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Trener trener = new Trener();
            Console.WriteLine("Trener unesen.");
            Console.WriteLine("Dodavanje igraca...");
            trener.DodajIgraca();
            Console.WriteLine("Igrac dodat.");
            Console.WriteLine("Uklanjanje igraca...");
            trener.UkloniIgraca();
            Console.WriteLine("Igrac uklonjen.");
            Igrac najboljiIgrac = trener.NajviseGolova();
            if (najboljiIgrac != null)
            {
                Console.WriteLine($"Igrac sa najvise golova: {najboljiIgrac._ime} {_brojPostignutihGolova}");
            }
            else
            {
                Console.WriteLine("Nema igraca.");
            }
        }
    }
}
