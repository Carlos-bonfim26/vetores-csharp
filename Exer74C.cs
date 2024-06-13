using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Exer74C
    {
        public static void Main(string[] args)
        {
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] vetor3 = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° valor da primeira tabela");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"digite o {i + 1}° valor da segunda tabela tabela");
                vetor2[i] = Convert.ToInt32(Console.ReadLine());

                vetor3[i] = vetor1[i] - vetor2[i];
            }
            for (int n = 0; n < vetor3.Length; n++)
            {
                Console.WriteLine($"a subtração dos valores das tabelas da {n + 1}° posição é {vetor3[n]}");
            }
        }
    }
}
