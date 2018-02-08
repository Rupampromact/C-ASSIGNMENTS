using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class English
    {
        public static void Main(string[] args)
        {
            String[] words ={ "boat", "house", "cat", "river", "cupboard" };

            void FindPlural()
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i] + 's';
                    Console.WriteLine(words[i]);
                }
            }
            FindPlural();
            String synonym = "buildings";
            var replaceWithSynonym=words.Select(t => t == words[1] ? synonym : t).ToArray();
            Console.WriteLine("After replacing with the synonym");
            foreach (string s in replaceWithSynonym)
                Console.WriteLine(s);
            replaceWithSynonym = replaceWithSynonym.Concat(new String[] { "sparrow" }).ToArray();
            Console.WriteLine("The length of the list after adding is" + " "+ replaceWithSynonym.Length);
            var allwithseven = Array.FindAll(replaceWithSynonym, t => t.Length == 7);
            Console.WriteLine("The words  with 7 characters are:");
            foreach (string v in allwithseven)
                Console.WriteLine(v);
            Console.WriteLine("The 3rd word in the array is:" + " " + replaceWithSynonym[2]);
             Array.Sort(replaceWithSynonym);
            Console.WriteLine("The words after sorting:");
            foreach (string c in replaceWithSynonym)
                Console.WriteLine(c);
            Array.Reverse(replaceWithSynonym);
            Console.WriteLine("The words after reversing:");
            foreach (string c in replaceWithSynonym)
                Console.WriteLine(c);
        }
    }
}
