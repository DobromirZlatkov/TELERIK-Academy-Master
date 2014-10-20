using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPolynomialsMethod
{
    class TwoPolynomialsMethod
    {
        static void Main(string[] args)
        {
            // input firstPolinomal
            Console.WriteLine("Enter Length of first Polinominal");
            int n = int.Parse(Console.ReadLine());
            decimal[] firstPolinominal = new decimal[n];

            Console.WriteLine("Enter numbers to Fill the Polinominal");
            for (int i = 0; i < firstPolinominal.Length; i++)
            {
                firstPolinominal[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(new string('-', 70));
            // input secondPolinomal
            Console.WriteLine("Enter Length of second Polinominal");
            int m = int.Parse(Console.ReadLine());
            decimal[] secondPolinominal = new decimal[m];

            Console.WriteLine("Enter numbers to Fill the Polinominal");
            for (int i = 0; i < secondPolinominal.Length; i++)
            {
                secondPolinominal[i] = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("First Polinominal");
            PrintPolinomal(firstPolinominal);
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Second Polinominal");
            PrintPolinomal(secondPolinominal);
            Console.WriteLine(new string('-', 70));

            Console.WriteLine("Substraction of the polynominals");
            decimal[] substractArray = SubstractPolinominals(firstPolinominal, secondPolinominal);
            PrintPolinomal(substractArray);
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Multiplicate polinominals");
            decimal[] multiPolinominal = MultiplicationPolinominals(firstPolinominal, secondPolinominal);
            PrintPolinomal(multiPolinominal);
            Console.WriteLine(new string('-', 70));
        }

        private static decimal[] MultiplicationPolinominals(decimal[] firstPolinominal, decimal[] secondPolinominal)
        {
            decimal[] multiPolinominal = new decimal[firstPolinominal.Length + secondPolinominal.Length];
            for (int i = 0; i < firstPolinominal.Length; i++)
            {
                for (int j = 0; j < secondPolinominal.Length; j++)
                {
                    int temp = i + j;
                    multiPolinominal[temp] += firstPolinominal[i] * secondPolinominal[j];
                }
            }
           
            return multiPolinominal;
        }
        // vadi po-dulgiqt ot po - kusiqt izraz
        private static decimal[] SubstractPolinominals(decimal[] firstPolinominal, decimal[] secondPolinominal)
        {
            int length = Math.Max(firstPolinominal.Length, secondPolinominal.Length);
            
            decimal[] substractArray = new decimal[length];

            if (firstPolinominal.Length >= secondPolinominal.Length)
            {
               for (int i = 0; i < secondPolinominal.Length; i++)
                {
                    substractArray[i] = firstPolinominal[i] - secondPolinominal[i];
                }
               for (int i = secondPolinominal.Length; i < firstPolinominal.Length; i++)
               {
                   substractArray[i] = firstPolinominal[i];
               }
            }
            else
            {
                for (int i = 0; i < firstPolinominal.Length; i++)
                {
                    substractArray[i] = secondPolinominal[i] - firstPolinominal[i];
                }
                for (int i = firstPolinominal.Length; i < secondPolinominal.Length; i++)
                {
                    substractArray[i] = secondPolinominal[i];
                }
            }


            return substractArray;
        }
       
        // pri printiraneti ima neshto kato bug kogato e otricatelno 4isloto se polu4ava + -number.
        // rovih dosta v foruma v opredeleni testove navsqkude iznikva podoben bug
        // taka 4e sum predpo4el da e navsqkude otkolkoto na opredeleni mesta ;]
        private static void PrintPolinomal(decimal[] firstPolinominal)
        {
            for (int i = firstPolinominal.Length - 1; i >= 0; i--)
            {
                if (i != 0 && firstPolinominal[i] != 0)
                {                   
                   Console.Write(firstPolinominal[i] + "x^" + i + " + ");   
                }
                else if (i == 0)
                {                    
                    Console.Write(firstPolinominal[i]);
                }
               
            }
            Console.WriteLine();
        }
    }
}
