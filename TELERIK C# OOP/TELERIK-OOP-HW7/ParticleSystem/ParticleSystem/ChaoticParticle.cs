using System;
using System.Collections.Generic;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        private const int MinSpeed = -3;
        private const int MaxSpeed = 3;
        protected Random rand = new Random();

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed)
            : base(position, speed)
        {
        }
        public override IEnumerable<Particle> Update()
        {
            this.Accelerate(new MatrixCoords(this.Speed.Row*-1, this.Speed.Col*-1));

            this.Accelerate(new MatrixCoords(this.rand.Next(MinSpeed,MaxSpeed+1),this.rand.Next(MinSpeed,MaxSpeed+1)));
            return base.Update();
        }
        
        public override char[,] GetImage()
        {
            return new char[,] { { 'R' } };
        }
    }
}
