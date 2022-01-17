using System;
using System.Collections.Generic;

namespace harjoitus12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pakka = new List<string>();

            for (int i = 0; i < 13; i++)
            {
                pakka.Add("Pata - " + (i + 1));
                pakka.Add("Hertta - " + (i + 1));
                pakka.Add("Ruutu - " + (i + 1));
                pakka.Add("RIsti - " + (i + 1));
            }

            foreach (string kortti in pakka)
            {
                Console.WriteLine(kortti);
            }
        }
    }
}
