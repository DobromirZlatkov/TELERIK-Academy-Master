using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed,int power)
            : base(position, speed)
        {
            this.Power = power;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '^' } };
        }

        public int Power { get; private set; }        
    }
}
