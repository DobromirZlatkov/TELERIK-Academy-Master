using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class MovingLetters
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            int maxLenght = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (maxLenght < words[i].Length)
                {
                    maxLenght = words[i].Length;
                }
            }
            StringBuilder shits = ExtractLetters(words, maxLenght);
            MoveLetters(shits);
            
        }

        private static void MoveLetters(StringBuilder shits)
        {
            int movement = 0;          
            for (int i = 0; i < shits.Length; i++)
            {
                char temp = shits[i];
                movement = char.ToLower(shits[i]) - 'a' + 1 + i;
                if (movement >= shits.Length)
                {
                    movement = movement % shits.Length;
                }                
                shits.Remove(i, 1);
                shits.Insert(movement, temp);
            }
            Console.WriteLine(shits);
        }

        private static StringBuilder ExtractLetters(string[] words, int maxLenght)
        {
            StringBuilder shits = new StringBuilder();
            for (int i = 1; i <= maxLenght; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Length - i >= 0)
                    {
                        shits.Append(words[j][words[j].Length - i]);
                    }
                }
            }
            return shits;
        }
    }
}
