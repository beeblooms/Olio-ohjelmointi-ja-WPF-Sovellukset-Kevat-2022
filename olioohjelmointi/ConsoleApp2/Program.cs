using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            opiskelija opiskelija1 = new opiskelija("Pekka", "12345", 0);
            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintopisteitä(10);
            opiskelija1.MuokkaaOpintopisteitä(15);
            opiskelija1.TulostaData();
        }
    }
}
