using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NyelvvizsgaForm
{
    class Vizsga
    {
        string nyelv;

        public string Nyelv
        {
            get => nyelv;
        }

        bool siker;

        public bool Siker { get => siker; }

        public static int Sikeres = 0;
        public static int Siktelen = 0;

        //public int SikerDb { get => Sikeres; }
        //public int SikertelenDb { get => Siktelen; }

        List<int> darab = new List<int>();

        public int OsszesDb
        {
            get => darab.Sum();
        }

        public int DarabSzam(int evszam)
        {
            if (darab.Count == 0)
            {
                return 0;
            }
            else
            {
                return darab[evszam - 2009];
            }
        }

        public Vizsga(string nyelv, bool siker, List<int> adatok)
        {
            this.nyelv = nyelv;
            this.siker = siker;
            darab = adatok;
            if (siker)
            {
                Sikeres++;
            }
            else
            {
                Siktelen++;
            }
        }

        public Vizsga(string nyelv)
        {
            this.nyelv = nyelv;
            Sikeres++;
        }

        public Vizsga(string nyelv, bool siker)
        {
            this.nyelv = nyelv;
            if (siker)
            {
                Sikeres++;
            }
            else
            {
                Siktelen++;
            }
        }
    }
}
