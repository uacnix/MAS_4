using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS4
{
    class Spolka : Podmiot
    {
        public readonly string nrKRS;
        public TypySpolek typ { get; private set; }
        private int _KapitalZakladowy;
        public int KapitalZakladowy {
            get
            {
                return _KapitalZakladowy;
            }
            private set {
                if (value < 100000 && typ.Equals(TypySpolek.SA))
                {
                    throw new Exception("Kapitał zakładowy spółki akcyjnej nie może być mniejszy niż 100000 PLN!");
                }
                if (value < 5000 && typ.Equals(TypySpolek.ZOO)){
                    throw new Exception("Kapitał zakładowy spółki z ograniczoną odpowiedzialnością nie może być mniejszy niż 5000PLN!");
                }
                _KapitalZakladowy = value;
            }
        }
        public string Nazwa { get; private set; }
        public Spolka(string Nazwa,string iKRS,TypySpolek typ,int kapital)
        {
            this.Nazwa = Nazwa;
            this.typ = typ;
            KapitalZakladowy = kapital;
            if (Podmiot.KRS.ContainsKey(iKRS))
                throw new Exception("Numer KRS jest przypisany do spółki " + Podmiot.KRS[iKRS]);
            else
            {
                nrKRS = iKRS;
                KRS.Add(iKRS, this);
            }
        }
        public override string ToString()
        {
            return Nazwa + " " + typ + " KRS:" + nrKRS + " Kapitał zakładowy:" + KapitalZakladowy;
        }
    }
}
