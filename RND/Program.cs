using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[1000];
            int rnd = 0;
            Random random = new Random();
            for (int i = 0; i < 1000000; i++)
            {

                rnd = random.Next(0, 1000);
                ints[rnd] = ints[rnd] + 1;
            }
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(i + " wurde " + ints[i] + " mal generiert!");
            }
            Console.ReadKey();
        }
    }
}
