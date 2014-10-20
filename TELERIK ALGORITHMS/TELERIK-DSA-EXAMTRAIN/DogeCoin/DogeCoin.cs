
namespace papaz{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class DogeCoin
    {
        static void Main()
        {
            string MatrixSizes = Console.ReadLine();
            var NandM = MatrixSizes.Split(' ');
            int N = int.Parse(NandM[0]);
            int M = int.Parse(NandM[1]);
            int K = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];

            for (int i = 0; i < K; i++)
            {
                string YandX = Console.ReadLine();
                var YandXAsArray = YandX.Split(' ');
                int x = int.Parse(YandXAsArray[0]);
                int y = int.Parse(YandXAsArray[1]);

                matrix[x, y] += 1;
            }


            var answer = new int[N, M];
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < M; y++)
                {

                    int up = 0;
                    int left = 0;
                    if (x > 0)
                    {
                        up = answer[x - 1, y];
                    }
                    if (y > 0)
                    {
                        left = answer[x, y - 1];
                    }

                    answer[x, y] = Math.Max(up, left) + matrix[x, y];
                }
            }

            Console.WriteLine(answer[N - 1, M - 1]);

        }
    }
}
