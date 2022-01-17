using System;
using System.Collections.Generic;

namespace kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Pekka");
            lista.Add("Matti");
            lista.Add("Juha");

            lista.Remove("Matti");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------Pino--------");
            Stack<string> pino = new Stack<string>();

            pino.Push("Kortti 1");
            pino.Push("Kortti 2");
            pino.Push("Kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek() + " on pinon päällä");

            pino.Pop();

            Console.WriteLine("---------Jono------");

            Queue<string> jono = new Queue<string>();

            jono.Enqueue("Matti");
            jono.Enqueue("Pekka");
            jono.Enqueue("Juha");

            jono.Dequeue();

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("------Sanakirja-------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("151219-6012", "Matti");
            sanakirja.Add("050616-5124", "Pekka");

            Console.WriteLine("Sanakirjassa on " + sanakirja.Count + " henkilöä");

            Console.WriteLine("Etsitään sanakirjasta avaimella '151219-6012', haettu henkilö on" + sanakirja["151219 - 6012"]);
            Console.WriteLine("Etsitään sanakirjasta avaimella '151219-6014', haettu henkilö on" + sanakirja["151219 - 6014"]);

            foreach(string avain in sanakirja.Keys)
            {
                Console.WriteLine("Sanakirjasta haettu avaimella: " + avain + ". Value " + sanakirja[avain]);
            }

            foreach (string henkilö in sanakirja.Values)
            {
                Console.WriteLine("Sanakirjasta haettu valuella: " + henkilö + ". Henkilön avain: " + sanakirja.Keys);
            }

            sanakirja.Add("151219-6012", "Juha");


        }
    }
}
