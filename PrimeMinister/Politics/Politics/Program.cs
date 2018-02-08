using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> PrimeMinister = new Dictionary<int, string>();

            PrimeMinister.Add( 1998, "Atal Bihari Vajpayee");
            PrimeMinister.Add(2014, "Narendra Modi");
            PrimeMinister.Add(2004, "Manmohan Singh");
            foreach (var p in PrimeMinister.Values)
                Console.WriteLine(p);
            //getting the prime minister of 2004
            Console.WriteLine("The  Prime Minister of 2004 is:" + PrimeMinister[2004]);
            //fetching current prime minister
            PrimeMinister[2017] = "Rupam Dhar";
            Console.WriteLine("After adding the current Prime Minister ");
            foreach (var c in PrimeMinister)
                Console.WriteLine(c);
            //Read Only Not Done

            //Sorting
            Console.WriteLine("Values after sorting:");
            var sortedDict = from entry in PrimeMinister orderby entry.Value ascending select entry;
            foreach (var c in sortedDict)
                Console.WriteLine(c);

        }
    }
}
