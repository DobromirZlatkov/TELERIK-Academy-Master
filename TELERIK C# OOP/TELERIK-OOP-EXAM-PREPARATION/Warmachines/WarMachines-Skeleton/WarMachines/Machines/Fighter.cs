using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Fighter : Machine, IFighter
    {
        private const int initialHealthPoints = 200;

        public Fighter(string name, double attack, double defense, bool steathMode)
            : base(name, initialHealthPoints, attack, defense)
        {
            this.StealthMode = steathMode;
        }


        public bool StealthMode
        {
            get;
            private set;
        }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            string machineAsString = base.ToString();
            var result = new StringBuilder();
            result.Append(machineAsString);
            string stealthModeAsString = this.StealthMode ? "ON" : "OFF";
            result.Append(" *Stealth: " + stealthModeAsString);

            return result.ToString();
        }
    }
}
