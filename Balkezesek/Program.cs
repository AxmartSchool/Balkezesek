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


            Console.ReadKey();

        }

        private static void AdatsorokSzama()
        {

            Console.WriteLine($"3. Feladat: {Jatekosok.Count()}");


        }
    }
}
