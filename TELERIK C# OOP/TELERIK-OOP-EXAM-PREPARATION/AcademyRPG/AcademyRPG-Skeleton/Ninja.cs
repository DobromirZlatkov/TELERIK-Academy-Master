using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IGatherer, IFighter
    {
        private const int NinjaHitPoints = 1;
        private const int NinjaInitialAttackPoints = 0;

        private int attackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = NinjaHitPoints;
            this.AttackPoints = NinjaInitialAttackPoints;
        }
        
        public int AttackPoints
        {
            get { return this.attackPoints; }
            private set { this.attackPoints = value; } 
        }

        public override bool IsDestroyed
        {
            get
            {
                return false;
            }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += (resource.Quantity * 2);
                return true;
            }
            return false;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (this.Owner == availableTargets[i].Owner && availableTargets[i].Owner == 0)
                {
                    availableTargets.Remove(availableTargets[i]);
                }
            }
            int currentHitPoints = int.MinValue;
            for (int i = 0; i < availableTargets.Count; i++)
            {               
                if (availableTargets[i].HitPoints > currentHitPoints)
                {
                    currentHitPoints = availableTargets[i].HitPoints;
                }
            }
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (currentHitPoints == availableTargets[i].HitPoints)
                {
                    return i;
                }
            }
            return -1; 
        }
    }
}
