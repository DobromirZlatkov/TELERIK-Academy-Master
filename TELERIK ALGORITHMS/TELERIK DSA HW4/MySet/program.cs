namespace MySet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class program
    {
        static void Main(string[] args)
        {
            MySet<int> numbers = new MySet<int>();
            for (int i = 0; i <= 10; i++)
            {
                numbers.Add(i);
            }

            Print(numbers);
            numbers.Remove(3);
            Console.WriteLine("---------------------------");
            Print(numbers);

        }

        public static void Print(MySet<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
