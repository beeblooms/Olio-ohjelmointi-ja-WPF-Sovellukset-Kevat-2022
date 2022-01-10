using System;
using System.Collections.Generic;
using System.Text;

namespace testapp
{
    class Koira
    {
        public string nimi;
        public int ikä;
        public string rotu;

        public Koira() { }
        public Koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Hauku();
        }


        public void TulostaData()
        {
            Console.WriteLine("Koiran nimi: " + nimi + ". ikä " + ikä + ". rotu " + rotu);
        }

        public void Hauku()
        {
            Console.WriteLine("Woof woof");
        }

        public void syö()
        {
            Console.WriteLine("Nam nam");
        }
    }
}
