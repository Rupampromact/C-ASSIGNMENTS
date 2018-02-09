using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalitycheck
{
    class Program
    {
        public static void Main(string[] args)
        {
            float X= 0.96f;
            float Y = 5.94f;
            float sum = X + Y;
            Console.WriteLine("The sum is:" + " " + sum);
            int a = 6;
            Console.WriteLine("The sum is equal to 6 ?" + ReferenceEquals(sum, a));
            bool itfComp = ((IComparable<float>)sum == (IComparable<int>)a);
            Console.WriteLine("The sum is equal to 6 ?" + itfComp);
            float result = X > Y ? X : Y;
            Console.WriteLine("The greater no is:" + result);
     
            

        }
    }
}
