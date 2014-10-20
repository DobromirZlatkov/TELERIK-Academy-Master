using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Mine : GetheringLocation
    {

        public Mine(string name)
            : base(name, LocationType.Mine, ItemType.Iron, ItemType.Armor)
        { 
        }

        public override Item ProduceItem(string name)
        {
            return new Iron(name, null);
        } 
    }
}
