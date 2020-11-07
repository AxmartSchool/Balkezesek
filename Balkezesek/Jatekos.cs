using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Jatekos
    {
        public string Nev { get; set; }
        public DateTime ElsoPalyaraLepes { get; set; }
        public DateTime UtolsoPalyaraLepes { get; set; }
        public int SulyFontban { get; set; }
        public int MagassagInchben { get; set; }




        public static List<Jatekos> Beolvasas()
        {
            var output = new List<Jatekos>();
            var sr = new StreamReader(@"..\..\balkezesek.csv", Encoding.UTF8);
            sr.ReadLine();
            string[] tempTomb;
            while (!sr.EndOfStream)
            {
                tempTomb = sr.ReadLine().Split(';');
                output.Add(new Jatekos() { Nev = tempTomb[0], ElsoPalyaraLepes = DateTime.Parse(tempTomb[1]), UtolsoPalyaraLepes = DateTime.Parse(tempTomb[2]), SulyFontban = int.Parse(tempTomb[3]), MagassagInchben = int.Parse(tempTomb[4]) });
            }

            sr.Close();

            return output;




        }


    }
}
