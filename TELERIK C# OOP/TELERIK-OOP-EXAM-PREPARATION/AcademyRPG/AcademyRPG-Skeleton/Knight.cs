using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Knight : Character, IFighter, IVulnerable
    {

        private const int KnightAttackPoints = 100;
        private const int KnightDefensePoints = 100;
        private const int KnightHitPoints = 100;
        //private int attackPoints;
        //private int defensePoints;

        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = KnightHitPoints;
        }

        public int AttackPoints
        {
            get { return KnightAttackPoints; }
        }

        public int DefensePoints
        {
            get { return KnightDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (this.Owner != availableTargets[i].Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;     
        }
    }
}
