using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class exer74E
    {
        public static void Main(string[] args)
        {
            int[] a = new int[15];
            int[] b = new int[15];
            int[] c = new int[30];
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"digite o {i +1}° valor da primeira lista");
                a[i] = Convert.ToInt32(Console.ReadLine());
                c[x] = a[i];
                x++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° valor da segunda lista");
                b[i] = Convert.ToInt32(Console.ReadLine());
                c[x] = b[i];
                x++;
            }
            foreach (int item in c)
            {
                Console.WriteLine(" - " + item);
            }

        }
    }
}
