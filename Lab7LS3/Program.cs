using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7LS3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testowa = { 5, 13, 2, 25, 7, 17, 20, 8, 4 };
            BinaryHeap kopiec = new BinaryHeap(testowa.Length);

            for (int i = 0; i < testowa.Length; i++)
            {
                // kopiec.AddToHeap(testowa[i]);
                kopiec.AddToArray(testowa[i]);
            }
            kopiec.WypiszKopiec();
            Console.ReadKey();
        }
    }
}
