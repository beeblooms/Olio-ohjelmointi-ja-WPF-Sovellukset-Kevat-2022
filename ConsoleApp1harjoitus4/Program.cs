using System;

namespace ConsoleApp1harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Harvia", 90, 50); 

            harvia.NäytäTiedot(); 
            harvia.Tila = true; 
            harvia.NäytäTiedot(); 
            harvia.SäädäLämpötila(100); 
            harvia.SäädäLämpötila(60); 
            harvia.NäytäTiedot(); 
            harvia.Tila = false; 
        }
    }
}
