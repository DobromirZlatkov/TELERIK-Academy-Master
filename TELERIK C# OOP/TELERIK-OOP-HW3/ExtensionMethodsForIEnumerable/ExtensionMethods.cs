using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsForIEnumerable
{
    static class ExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> array)
        {
            dynamic sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> array)
        {
            dynamic sum = 1;
            foreach (var item in array)
            {
                sum *= item;
            }
            return sum;
        }

        public static T Min<T>(this IEnumerable<T> array)
        {
            dynamic min = long.MaxValue;
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> array)
        {
            dynamic max = long.MinValue;
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> array)
        {
            dynamic average = 0;
            int count = 0;
            foreach (var item in array)
            {
                average += item;
                count++;
            }
            return average / count;
        }
    }
}
