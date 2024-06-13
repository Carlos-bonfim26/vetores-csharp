using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class exer74J
    {
        public static void Main(string[] args)
        {
            int[] par = new int[6];
            int[] impar = new int[6];
            int[] n = new int[12];
            int y = 0;
            for (int i = 0; i < par.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1} ° número par:");
                par[i] = Convert.ToInt32(Console.ReadLine());
                if (par[i] % 2 != 0)
                {
                    while (par[i] % 2 != 0)
                    {
                        Console.WriteLine($"por favor digite o {i + 1} ° número par:");
                        par[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                n[y] = par[i];
                y++;
            }
            for (int i = 0; i < impar.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1} ° número ímpar:");
                impar[i] = Convert.ToInt32(Console.ReadLine());
                if (impar[i] % 2 == 0)
                {
                    while (impar[i] % 2 == 0)
                    {
                        Console.WriteLine($"por favor digite o {i + 1} ° número ímpar:");
                        impar[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                n[y] = impar[i];
                y++;
            }
            foreach (int res in n)
            {
                Console.WriteLine(res);
            }
        }
    }
}
