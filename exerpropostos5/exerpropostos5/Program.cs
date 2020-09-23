using System;

namespace exerpropostos5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;
            int[,] B;
            int[,] C;

            Console.WriteLine("DIGITE A QUANTIDADE DE LINHAS E COLUNAS DAS MATRIZES: ");
            string[] valores = Console.ReadLine().Split(' ');
            M = int.Parse(valores[0]);
            N = int.Parse(valores[1]);

            A = new int[M, N];
            B = new int[M, N];
            C = new int[M, N];

            Console.WriteLine("VALORES DA MATRIZ A: ");
            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES DA MATRIZ B: ");
            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i,j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("MATRIZ GERADA COM A SOMA DOS ELEMENTOS CORRESPONDENTES DAS MATRIZES ORIGINAIS: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
