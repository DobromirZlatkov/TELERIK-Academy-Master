using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapSackProblem
{
    class Product
    {
        public Product(string name, int weigth, int cost)
        {
            this.Weigth = weigth;
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }

        public int Weigth { get; set; }

        public int Cost { get; set; }
    }
}
