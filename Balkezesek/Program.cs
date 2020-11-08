using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Program
    {
        public static List<Jatekos> Jatekosok;

        static void Main(string[] args)
        {
            Jatekosok = Jatekos.Beolvasas();

            AdatsorokSzama();
            JatekosokMagassaga();
            EvszamBekeres();

            Console.ReadKey();

        }

        private static void EvszamBekeres()
        {
            Console.WriteLine("5. Feladat:");
            Console.Write("Kerek egy 1990 es 1999 kozotti evszamot: ");
            int evszam = int.Parse(Console.ReadLine());

            while (evszam < 1990 || evszam > 1999 )
            {
                Console.Write("Hibas adat!Kerek egy 1990 es 1999 kozotti evszamot: ");
                evszam = int.Parse(Console.ReadLine());
            }
        }

        private static void JatekosokMagassaga()
        {

            Console.WriteLine("4. Feladat:");
            var output = new Dictionary<string, float>();
            foreach (var j in Jatekosok)
            {
                if (j.UtolsoPalyaraLepes.Year ==  1999 && j.UtolsoPalyaraLepes.Month == 10  )
                {
                    Console.WriteLine($"\t{j.Nev}, {(float)j.MagassagInchben*2.54 :#.0} cm");
                }
            }



        }

        private static void AdatsorokSzama()
        {

            Console.WriteLine($"3. Feladat: {Jatekosok.Count()}");


        }
    }
}
