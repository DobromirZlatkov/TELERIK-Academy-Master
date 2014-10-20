using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : Machine, ITank
    {
        private const int initialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;

        public Tank(string name, double attack, double defense)
            : base(name, initialHealthPoints, attack, defense)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get;
            private set;
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;               
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
            }
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            string machineAsString = base.ToString();
            var result = new StringBuilder();
            result.Append(machineAsString);
            string defenseModeAsString = this.DefenseMode ? "ON" : "OFF";
            result.Append(" *Defense: " + defenseModeAsString);
           
            return result.ToString();
        }
    }
}
