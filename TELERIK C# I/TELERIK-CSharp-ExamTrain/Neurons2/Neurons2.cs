using System;
class Neurons2
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        while (inputLine != "-1")
        {
            uint inputNumber = uint.Parse(inputLine);
            char[] numberBinaryDigits = Convert.ToString(inputNumber, 2).PadLeft(32, '0').ToCharArray();
           
            

            
            bool isInsideNeuron = false;
            bool isONBoundery = false;
            bool beenInNeuron = false;

            for (int i = 0; i < numberBinaryDigits.Length; i++)
            {
                if (numberBinaryDigits[i] == '1')
                {
                    isONBoundery = true;
                    if (isInsideNeuron)
                    {
                        isInsideNeuron = false;
                        beenInNeuron = true;                         
                    }

                    numberBinaryDigits[i] = '0';
                }
                else
                {
                    if (!beenInNeuron && isONBoundery)
                    {
                        isInsideNeuron = true;
                        isONBoundery = false;

                    }
                    if (isInsideNeuron)
                    {
                        numberBinaryDigits[i] = '1';
                    }
                    
                }
            }


            if (!isInsideNeuron)
            {
                uint resultNumber = Convert.ToUInt32(new string(numberBinaryDigits), 2);
                Console.WriteLine(resultNumber);                
            }
            else
            {
               Console.WriteLine(0);
            }

            inputLine = Console.ReadLine();
        }
    }
}
