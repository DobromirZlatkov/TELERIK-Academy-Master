using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTHeRabbit
{
    class JoroTHeRabbit
    {
        private static int[] GetInputNumbers(string[] inputSeparator)
        {
            int[] papaz = new int[inputSeparator.Length];
            for (int i = 0; i < papaz.Length; i++)
            {
                papaz[i] = int.Parse(inputSeparator[i]);
            }

            return papaz;
        }

        private static int FindSomeWayTheResult(int[] inputNumbers)
        {
            
            int result = int.MinValue;
            int counter = 0;
            int jump = 0;
            for (int enterStep = 0; enterStep < inputNumbers.Length; enterStep++)
            {
                for (int jumpStep = 1; jumpStep <= inputNumbers.Length; jumpStep++)
                {
                    if (result < counter)
                    {
                        result = counter;
                    }                   
                    counter = 1;
                    for (int i = enterStep; i < inputNumbers.Length;)
                    {
                        
                        if (i + jumpStep >= inputNumbers.Length - 1)
                        {
                            jump = (i + jumpStep) % (inputNumbers.Length);

                            if (inputNumbers[i] >= inputNumbers[jump])
                            {
                                break;
                            }
                            else
                            {
                                counter++;                                
                            }
                        }
                        else
                        {
                            if (inputNumbers[i] >= inputNumbers[i + jumpStep] )
                            {
                                break;
                            }
                            else
                            {
                                counter++;
                            }
                        }
                        if (i + jumpStep >= inputNumbers.Length - 1)
                        {
                            i = (i+jumpStep) % inputNumbers.Length;
                        }
                        else
                        {
                            i += jumpStep;
                        }
                    }
                }
                
            }


            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputSeparator = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            
            int[] inputNumbers = GetInputNumbers(inputSeparator);

            int result = FindSomeWayTheResult(inputNumbers);
            Console.WriteLine(result);
            
        }                
    }
}
