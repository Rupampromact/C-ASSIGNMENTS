using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> invent = new List<string>();
            invent.Add("Tomato");
            invent.Add("Potato");
            invent.Add("ToMato");
            invent.Add("Potato");
            invent.Add("Red Tomato");
            invent.Add("Tomato Catchup");
            invent.Add("Grapes");
            invent.Add("grapes");
            invent.Add("potato");
            var pro = invent.ConvertAll(d => d.ToLower());
            int count = 0;
            foreach (var p in pro)
            {
                if (p=="tomato")
                    count++;
            }
            Console.WriteLine("The no of strings containing tomato"+" "+count);
            //Console.WriteLine("The indexes are:" + invent.FindIndex(collection => collection.SequenceEqual("Potato")) + " " + invent.FindLastIndex(collection => collection.SequenceEqual("Potato")));
            var result = invent.Select((c, i) => new { String = c, index = i })
                        .Where(list => list.String == "Potato")
                        .ToList();
            foreach (var i in result)
                Console.WriteLine(i);
        }
    }
}
