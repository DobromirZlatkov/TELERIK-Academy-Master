using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Guitar
    {
        static void Main(string[] args)
        {
            int CNumberOfSongs = int.Parse(Console.ReadLine());

            string[] volumesString = Console.ReadLine().Split(' ');

            int[] volumesInteger = new int[volumesString.Length];

            for (int i = 0; i < volumesString.Length; i++)
            {
                volumesInteger[i] = int.Parse(volumesString[i]);
            }

            int BStart = int.Parse(Console.ReadLine());
            int MMax = int.Parse(Console.ReadLine());

            int[,] dpMatrix = new int[CNumberOfSongs + 1, MMax + 1];

            dpMatrix[0, BStart] = 1;

            for (int currentVolumeChange = 1; currentVolumeChange <= CNumberOfSongs; currentVolumeChange++)
            {
                for (int possibleVolume = 0; possibleVolume <= MMax; possibleVolume++)
                {
                    if (dpMatrix[currentVolumeChange - 1, possibleVolume] == 1)
                    {
                        int newPossibleVolume = possibleVolume - volumesInteger[currentVolumeChange - 1];

                        if (newPossibleVolume >= 0)
                        {
                            dpMatrix[currentVolumeChange, newPossibleVolume] = 1;
                        }

                        newPossibleVolume = possibleVolume + volumesInteger[currentVolumeChange - 1];

                        if (newPossibleVolume <= MMax)
                        {
                            dpMatrix[currentVolumeChange, newPossibleVolume] = 1;
                        }
                    }
                }
       
            }

            for (int i = MMax; i >= 0; i--)
            {
                if (dpMatrix[CNumberOfSongs, i] == 1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
