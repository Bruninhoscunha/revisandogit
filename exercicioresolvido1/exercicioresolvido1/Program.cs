using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace exercicioresolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] M;

            N = int.Parse(Console.ReadLine());
            M = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    M[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i, i] + " ");
            }

            Console.WriteLine(" ");

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (M[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + cont.ToString());
        }
    }
}
