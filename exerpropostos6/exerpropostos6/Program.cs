using System;
using System.Globalization;

namespace exerpropostos6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int result;

            N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                result = N * N;
                if (result / N == N)
                {
                    Console.WriteLine(N.ToString() + "è um quadrado perfeito");
                }

            }
        }
    }
}
