namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public void PrintStatistics(double[] arr, int count)
        {
            double maxValue = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];       
                }
            }

            PrintMax(maxValue);
            double minValue = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            PrintMin(maxValue);
            double tmp = 0;

            for (int i = 0; i < count; i++)
            {
                tmp += arr[i];
            }

            double avarage = tmp / count;

            PrintAvg(avarage);
        }
    }
}
