﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Lumberjack : Character, IGatherer, IVulnerable
    {
        public Lumberjack(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 50;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                return true;
            }

            return false;
        }
    }
}