using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigthQueens
{
    class EigthQueens
    {
        static void Main(string[] args)
        {
            QueenSolver solver = new QueenSolver(8);

            Console.WriteLine(solver.FindAllSolutions());

        }
    }
}
