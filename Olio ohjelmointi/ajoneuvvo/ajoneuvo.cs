using System;
using System.Collections.Generic;
using System.Text;

namespace ajoneuvvo
{
    class ajoneuvo
    {
        public string nimi;
        public int renkaat;
        public int nopeus;


        public void HaeTiedot()
        {
            Console.WriteLine ("Nimi: " + nimi + ". Renkaat: " + renkaat.ToString() + ". Nopeus: " + nopeus.ToString());

        }
    }
}
