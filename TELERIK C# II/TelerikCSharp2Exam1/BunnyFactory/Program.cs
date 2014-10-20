using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace BunnyFactory
{
    class Program
    {
        private static StringBuilder FillFactory()
        {
            StringBuilder factory = new StringBuilder();
            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }                
                factory.Append(input);
            }
            return factory;
        }
        static void Main(string[] args)
        {

            StringBuilder factory = FillFactory();
            
            int papaz = 1;
            BigInteger product = 1;
            BigInteger sum = 0;
            BigInteger numbersToTake = 0;
            while (numbersToTake < factory.Length)
            {

                    product = 1;
                    sum = 0;
                    numbersToTake = 0;
                        //take number of digits to sum and product
                    for (int i = 0; i < papaz; i++)
                    {
                        string lqlq = factory[i].ToString();
                        numbersToTake += BigInteger.Parse(lqlq);                
                    }
                    int usedDigits = (int)(papaz + numbersToTake);

                    // take the product and sum;
                    for (int i = papaz; i < numbersToTake + papaz; i++)
                    {
                        sum += BigInteger.Parse(factory[i].ToString());
                        product *= BigInteger.Parse(factory[i].ToString());                       
                    }
                    
                    // remove digits in stringbuilder-a
                    factory.Remove(0, usedDigits);
                    string lenght = sum.ToString() + product.ToString();
                    factory.Insert(0, lenght);
                    //removes 1 and 0
                    for (int i = 0; i < factory.Length; i++)
                    {
                        if (factory[i] == '0' || factory[i] == '1')
                        {
                            factory.Remove(i, 1);
                        }
                    }                    
                    papaz++;
            }

            for (int i = 0; i < factory.Length; i++)
            {
                if (factory[i] == '0' || factory[i] == '1')
                {
                    factory.Remove(i, 1);
                }
            }
            for (int i = 0; i < factory.Length; i++)
            {
                Console.Write(factory[i] + " ");
            }
            Console.WriteLine();
        }        
    }
}
