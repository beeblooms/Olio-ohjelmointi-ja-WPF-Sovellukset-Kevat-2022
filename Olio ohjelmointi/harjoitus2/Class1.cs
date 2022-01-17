using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus2
{
    class opiskelija
    {
        private string nimi;
        private string opiskelijaID;
        private int opintopisteet;

        public opiskelija(string _nimi, string _opiskelijaID, int _opintopisteet)
        {
            nimi = _nimi;
            opiskelijaID = _opiskelijaID;
            opintopisteet = _opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine(nimi + ". ID: " + opiskelijaID + ". Opintopisteet: " + opintopisteet);
        }

        public void MuokkaaOpintopisteitä(int määrä)
        { 
            opintopisteet += määrä;
        }
    }
}
