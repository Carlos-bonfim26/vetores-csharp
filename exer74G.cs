using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class exer74G
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int x = 0, y = 0;

            while (x < a.Length)
            {
                Console.WriteLine($"digite o {x + 1} da lista");
                a[x] = Convert.ToInt32(Console.ReadLine());
                x++;
            }
            x -= 1;
            while (y < b.Length)
            {

                b[y] = a[x];
                x--;
                y++;
            }
            Console.WriteLine("invertidos");
            foreach (int item in b)
            {
                Console.WriteLine("- " +  item);
            }
        }
    }
}
