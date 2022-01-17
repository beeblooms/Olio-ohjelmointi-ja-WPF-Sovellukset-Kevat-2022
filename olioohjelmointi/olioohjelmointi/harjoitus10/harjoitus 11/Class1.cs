using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_11
{
    class opiskelija
    {
        public string Etunimi;
        public string Sukunimi;
        public string Ryhmätunnus;
        public int OpiskelijaNumero;

        public void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija: {0} {1}. Ryhmätunnus: {2}. Opiskelija Numero: {3}", Etunimi, Sukunimi, Ryhmätunnus, OpiskelijaNumero);
        }
    }
}
