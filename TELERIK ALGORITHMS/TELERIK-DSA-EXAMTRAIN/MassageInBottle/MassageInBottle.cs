using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesInABottle
{
    class Program
    {
        static List<KeyValuePair<char, string>> chiphers = new List<KeyValuePair<char, string>>();
        static string message;

        static void Main()
        {
            message = Console.ReadLine();
            string chipher = Console.ReadLine();

            char key = char.MinValue;
            StringBuilder value = new StringBuilder();
            // A1B12C11D2
            for (int i = 0; i < chipher.Length; i++)
            {
                // if (char.IsLetter(chipher[i]))
                if (chipher[i] >= 'A' && chipher[i] <= 'Z')
                {
                    if (key != char.MinValue)
                    {
                        chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                        value.Clear();
                    }

                    key = chipher[i];
                }
                else
                {
                    value.Append(chipher[i]);
                }
            }

            if (key != char.MinValue)
            {
                chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                value.Clear();
            }
            chiphers = chiphers.OrderBy(x => x.Key).ToList();

            stack = new Stack<char>();
            Solve(0);

            Console.WriteLine(solutions.Count);
            // solutions.Sort();
            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }

        static List<string> solutions = new List<string>();
        static Stack<char> stack;
        static void Solve(int secretMessageIndex)
        {
            if (secretMessageIndex == message.Length)
            {
                var stackAsArray = stack.ToArray();
                stackAsArray = stackAsArray.Reverse().ToArray();
                solutions.Add(new string(stackAsArray));
                return;
            }

            foreach (var chipher in chiphers)
            {
                if (message.Substring(secretMessageIndex).StartsWith(chipher.Value))
                {
                    stack.Push(chipher.Key);
                    Solve(secretMessageIndex + chipher.Value.Length);
                    stack.Pop();
                }
            }
        }
    }
}