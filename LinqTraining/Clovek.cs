using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTraining
{
    public class Clovek
    {
        public Clovek(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }

        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }

        public int Vek { get; private set; }

        public bool Zletily { get => Vek > 17; }



        public override string ToString()
        {
            return Jmeno + " " + Prijmeni;
        }
    }
}
