using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaDecimalToBinary
{
    class HexaDecimalToBinary
    {
        static void Main(string[] args)
        {
            /*Write a program to convert hexadecimal numbers 
             * to binary numbers (directly).
            */

            Console.WriteLine("Enter Hexadecimal Number");
            string hexaNumber = Console.ReadLine();
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexaNumber, 16), 2);
            Console.WriteLine(binaryval);
            
            // second way
            string[] cases = {"0000","0001","0010","0011","0100","0101","0110","0111","1000","1001",
                           "1010","1011","1100","1101","1110","1111"};
            binaryval = "";
            for (int j = 0; j < hexaNumber.Length; j++)
            {
                if (hexaNumber[j] >= '0' && hexaNumber[j] <= '9')
                {
                    binaryval += cases[hexaNumber[j] - '0'];   
                }
                else
                {
                    binaryval += cases[hexaNumber[j] - '7']; 
                }               
            }
            Console.WriteLine(binaryval);
            
        }               
    }
}
