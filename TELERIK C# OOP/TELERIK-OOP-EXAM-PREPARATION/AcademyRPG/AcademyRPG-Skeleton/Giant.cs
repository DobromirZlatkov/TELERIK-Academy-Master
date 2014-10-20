using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IGatherer, IFighter, IVulnerable
    {
        private const int GiantAttackPoints = 150;
        private const int GiantDefensePoints = 80;
        private const int GiantHitPoints = 200;
        private const int GiantOwner = 0;

        private int attackPoints;
        private bool isGiantAlreadyGathered = false;

        public Giant(string name, Point position)
            : base(name, position, GiantOwner)
        {
            this.HitPoints = GiantHitPoints;
            this.AttackPoints = GiantAttackPoints;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get { return GiantDefensePoints; }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!isGiantAlreadyGathered)
                {
                    this.AttackPoints += 100;
                }
                isGiantAlreadyGathered = true;
                return true;
            }
            return false;
        }
        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = availableTargets.Count - 1; i >= 0; i--)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
