using System;

namespace albumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            albumi.LisääKappale(new kappale("KAppale 1", "06:25"));
            albumi.LisääKappale(new kappale("KAppale 1", "06:25"));
            albumi.LisääKappale(new kappale("KAppale 1", "06:25"));
        }
    }
}
