using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class exer74D
    {
        public static void Main(string[] args)
        {
            double[] a = new double[15];
            double[] b = new double[15];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° valor:");
                a[i] = Convert.ToDouble(Console.ReadLine());
                b[i] = Math.Pow(a[i], 2);
            }
            for(int n = 0; n < b.Length; n++)
            {
                Console.WriteLine($"o quadrado de {a[n]} = {b[n]}");
            }
        }
    }
}
