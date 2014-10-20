using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Task2Arrays
{
    class Program
    {

        private static List<long> LoadArray()
        {
            List<long> lqlq = new List<long>();
            string input = Console.ReadLine();
            string[] haha = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < haha.Length; i++)
            {
                lqlq.Add(long.Parse(haha[i]));
            }
            return lqlq;
        }


        static void Main(string[] args)
        {
            List<long> playGround = LoadArray();

            int mollyPath = (int)playGround[0];
            int dollyPath = (playGround.Count - 1) - (int)playGround[(playGround.Count - 1)];
            
            long mollyFLowers = playGround[0];
            playGround[0] = 0;


            long dollyFlowers = playGround[playGround.Count - 1];
            playGround[playGround.Count - 1] = 0;

            while (playGround[mollyPath] != 0 || playGround[dollyPath] != 0)
            {
                
                mollyFLowers += playGround[mollyPath];
                dollyFlowers += playGround[dollyPath];
                if (mollyPath == dollyPath)
                {
                    mollyFLowers += playGround[mollyPath] / 2;
                    dollyFlowers += playGround[mollyPath] / 2;
                    playGround[mollyPath] = playGround[mollyPath] % 2;
                }
                
              
                long dolyCurrrent = playGround[dollyPath];
                long current = playGround[mollyPath];
                playGround[mollyPath] = 0;
                playGround[dollyPath] = 0;

                if (current <= playGround.Count - 1)
                {
                    mollyPath += (int)current;
                }
                if (mollyPath > playGround.Count - 1)
                {
                    mollyPath %= (playGround.Count - 1);
                    //mollyPath = (int)current;
                    //current = (playGround[mollyPath]) % (playGround.Count - 1);
                    //mollyPath = (int)current;
                }
                
                // opravqne s moly 1vo









                int papaz = 0;
                // doly
                if (dolyCurrrent >= 0)
                {
                    dollyPath -= (int)dolyCurrrent;
                    papaz = dollyPath;
                    dollyPath = -dollyPath;
                    //dolyCurrrent = dollyPath;
                }
                if (papaz < 0)
                {

                    dollyPath %= (playGround.Count - 1);
                    dollyPath = Math.Abs(dollyPath);
                    dollyPath = (playGround.Count + 1) - dollyPath;
                }
                           
            }
            Console.WriteLine(dollyFlowers);
            Console.WriteLine(mollyFLowers);
        }      
    }
}
