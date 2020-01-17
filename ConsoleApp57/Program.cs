using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tmp;
            Console.Write("How many elements will the array have? (1-1000): n=");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tell me tab1[{0}]", i);
                tab1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tab1[i] < tab1[j])
                    {
                        tmp = tab1[i]; tab1[i] = tab1[j]; tab1[j] = tmp;
                    }
                }
            }
            foreach (int elem in tab1) Console.WriteLine("Array elemet: {0}", elem);
            Console.ReadKey();
        }
    }
}
