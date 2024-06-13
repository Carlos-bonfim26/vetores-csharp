using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class exer74I
    {
        public static void Main(string[] args)
        {
            float[] a = new float[5];
            float[] b = new float[5];

            for (int i = 0; i < a.Length; i++) {
                Console.WriteLine($"digite o {i + 1} valor:");
                a[i] = float.Parse(Console.ReadLine());
                if (a[i] % 2 == 0)
                {
                    b[i] = a[i] / 2f;
                }
                else
                {
                    b[i] = a[i] * 1.5f;
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"1° vetor: {a[i]}, 2° vetor {b[i]}");
            }
        }
    }
}
