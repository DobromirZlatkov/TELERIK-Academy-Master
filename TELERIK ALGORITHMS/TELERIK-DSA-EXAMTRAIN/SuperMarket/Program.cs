using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullCommand = Console.ReadLine();
            List<string> queque = new List<string>();
            Dictionary<string, int> numberOfPEopleWithTheSameName = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            while (fullCommand != "End")
            {
                string[] commandAsStringArr = fullCommand.Split(' ');
                string command = commandAsStringArr[0];
                switch (command)
                {
                    case "Append":
                        if (!numberOfPEopleWithTheSameName.ContainsKey(commandAsStringArr[1]))
                        {
                            numberOfPEopleWithTheSameName[commandAsStringArr[1]] = 0;
                        }

                        numberOfPEopleWithTheSameName[commandAsStringArr[1]]++;

                        queque.Add(commandAsStringArr[1]);
                        sb.AppendLine("OK");
                        break;
                    case "Insert":
                        int papaz = int.Parse(commandAsStringArr[1]);

                        if (papaz > queque.Count || papaz < 0)
                        {
                            sb.AppendLine("Error");
                        }
                        else
                        {                            
                            queque.Insert(papaz, commandAsStringArr[2]);
                            if (!numberOfPEopleWithTheSameName.ContainsKey(commandAsStringArr[2]))
                            {
                                numberOfPEopleWithTheSameName[commandAsStringArr[2]] = 0;
                            }

                            numberOfPEopleWithTheSameName[commandAsStringArr[2]]++;
                            sb.AppendLine("OK");
                        }
                        break;
                    case "Find":
                        if (!numberOfPEopleWithTheSameName.ContainsKey(commandAsStringArr[1]))
                        {
                            sb.AppendLine("0");
                        }
                        else
                        {
                            sb.AppendLine(numberOfPEopleWithTheSameName[commandAsStringArr[1]].ToString());
                        }    
                        break;

                    case "Serve":
                        var numberOfPeopleToBeSurved = int.Parse(commandAsStringArr[1]);
                        if (numberOfPeopleToBeSurved > queque.Count  || numberOfPeopleToBeSurved < 0)
                        {
                            sb.AppendLine("Error");
                        }
                        else
                        {
                            for (int i = 0; i < numberOfPeopleToBeSurved; i++)
                            {
                                sb.Append(queque[i]);
                                sb.Append(" ");
                                numberOfPEopleWithTheSameName[queque[i]]--;
                            }
                            sb.AppendLine();
                            queque.RemoveRange(0, numberOfPeopleToBeSurved);
                        }
                        break;
                }

                fullCommand = Console.ReadLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
