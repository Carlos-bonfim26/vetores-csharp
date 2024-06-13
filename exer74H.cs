using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class exer74H
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            int[] d = new int[15];
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° valor da primeira lista");
                a[i] = Convert.ToInt32(Console.ReadLine());
                d[x] = a[i];
                x++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° valor da segunda lista");
                b[i] = Convert.ToInt32(Console.ReadLine());
                d[x] = b[i];
                x++;
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° valor da terceira lista");
                c[i] = Convert.ToInt32(Console.ReadLine());
                d[x] = c[i];
                x++;
            }
            foreach (int item in d)
            {
                Console.WriteLine(" - " + item);
            }
        }
    }
}
