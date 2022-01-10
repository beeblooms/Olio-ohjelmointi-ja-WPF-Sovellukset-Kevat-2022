using System;

namespace ajoneuvvo
{
    class Program
    {
        static void Main(string[] args)
        {
            ajoneuvo auto = new ajoneuvo();

            auto.nimi = "Auto";
            auto.renkaat = 5;
            auto.nopeus = 110;

            auto.HaeTiedot();
        }
    }
}
