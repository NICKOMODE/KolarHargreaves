using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolarHargreaves
    //David
{
    public class Rapper
    {
        public int ID { get; set; } 
        public string Prezdivka { get; set; }
        public int Narodnost { get; set; }
        public int Zanr { get; set; }
        public bool Nazivu { get; set; }
        public int Vek { get; set; }
        public bool Aktivni { get; set; }
        public bool Zenaty { get; set; }
        public string Pohlavi { get; set; }

        public Rapper(int id, string prezdivka, int narodnost, int zanr, bool nazivu, int vek, bool aktivni, bool zenaty, string pohlavi)
        {
            ID = id;
            Prezdivka = prezdivka;
            Narodnost = narodnost;
            Zanr = zanr; 
            Pohlavi = pohlavi;
            Vek = vek;
            Aktivni = aktivni;
            Zenaty = zenaty;
            Nazivu = nazivu;
        }
    }
}
