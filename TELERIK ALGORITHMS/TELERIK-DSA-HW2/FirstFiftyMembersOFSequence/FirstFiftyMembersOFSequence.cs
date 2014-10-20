using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFiftyMembersOFSequence
{
    class FirstFiftyMembersOFSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            for (int i = 0; i < 51; i++)
			{		
                int current = queue.Dequeue();
                Console.Write(current + ", ");

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
        }
    }
}
