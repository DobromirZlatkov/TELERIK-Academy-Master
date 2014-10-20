using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NotImplementedException("Pilot name cannot be null");
                }
                this.name = value;
            }
        }

        public Pilot(string initialName)
        {
            this.Name = initialName;
            this.machines = new List<IMachine>();
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Machine cannot be null");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            
            string numberOfMachines = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string machineWord = this.machines.Count == 1 ? "machine" : "machines";

            result.Append(string.Format("{0} - {1} {2}", this.Name, numberOfMachines, machineWord));

            if (this.machines.Count !=0 )
            {
                result.AppendLine();
                var sortedMachines = this.machines
                                 .OrderBy(mach => mach.HealthPoints)
                                 .ThenBy(mech => mech.Name);

                foreach (var machine in sortedMachines)
                {
                    result.AppendLine(machine.ToString());
                } 
            }

            

            return result.ToString().TrimEnd();
        }
    }
}
