using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frames
{
    class Frame
    {
        public int Left { get; set; }

        public int Rigth { get; set; }

        public override string ToString()
        {
            return "(" + Left + ", " + Rigth + ")";
        }
    }
    class Program
    {
       static SortedSet<string> result = new SortedSet<string>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Frame[] allFrames = new Frame[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersarr = numbers.Split(' ');
                allFrames[i] = new Frame
                {
                    Left = int.Parse(numbersarr[0]),
                    Rigth = int.Parse(numbersarr[1]),
                };
            }


            GeneratePermutations(allFrames, 0 );

            StringBuilder output = new StringBuilder();
            foreach (var item in result)
            {
                output.AppendLine(item);
            }
            Console.WriteLine(result.Count);
            Console.WriteLine(output.ToString().TrimEnd());
        }

        static void GeneratePermutations(Frame[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result.Add(Print(arr));
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                SwapFrame(arr[k]);
                GeneratePermutations(arr, k + 1);
                SwapFrame(arr[k]);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);

                    GeneratePermutations(arr, k + 1);
                    SwapFrame(arr[k]);
                    GeneratePermutations(arr, k + 1);
                    SwapFrame(arr[k]);

                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static string Print<T>(T[] arr)
        {
            return string.Join(" | ", arr);
        }

        static void SwapFrame(Frame frame)
        {
            int oldFirst = frame.Left;
            frame.Left = frame.Rigth; 
            frame.Rigth = oldFirst;
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
