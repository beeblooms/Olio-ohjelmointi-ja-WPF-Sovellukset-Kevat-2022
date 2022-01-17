using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6
{
    class Class1
    {
        class Koira : Eläin
        {
            public string Rotu;
            public int Ikä;

            public static int instanssit = 0;

            public Koira(string rotu, int ikä)
            {
                Rotu = rotu;
                Ikä = ikä;

                instanssit++;
            }

            public static new void KuinkaMonta()
            {
                Console.WriteLine("Koiria on elossa: " + instanssit);
            }

            public override void Ääntele()
            {
                Console.WriteLine("Woof Woof");
            }
        }
    }
}
