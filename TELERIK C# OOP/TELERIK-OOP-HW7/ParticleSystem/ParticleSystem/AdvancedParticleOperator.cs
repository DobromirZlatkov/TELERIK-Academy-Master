using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class AdvancedParticleOperator : ParticleUpdater
    {
        public string guz;
        private List<ParticleAttractor> attractorsCurrFrame = new List<ParticleAttractor>();
        private List<Particle> particles = new List<Particle>();
        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var attractorCandidate = p as ParticleAttractor;           
            if (attractorCandidate == null)
            {
                this.particles.Add(p);
            }
            else
            {
                this.attractorsCurrFrame.Add(attractorCandidate);
            }
            return base.OperateOn(p);            
        }
        public override void TickEnded()
        {            
            foreach (var attractor in this.attractorsCurrFrame)
            {
                foreach (var particle in this.particles)
                {
                    var currAcceleration = GetAccelerationFromParticleAttractor(attractor, particle);

                    particle.Accelerate(currAcceleration);                    
                }
            }
            this.attractorsCurrFrame.Clear();
            this.particles.Clear();
            base.TickEnded();
            
        }

        private static MatrixCoords GetAccelerationFromParticleAttractor(ParticleAttractor attractor, Particle particle)
        {
            var currParticleToAttractorVector = attractor.Position - particle.Position;

            int pToAttrRow = currParticleToAttractorVector.Row;
            pToAttrRow = DecreaseVectorCoordToPower(attractor, pToAttrRow);

            int pToAttrCol = currParticleToAttractorVector.Col;
            pToAttrCol = DecreaseVectorCoordToPower(attractor, pToAttrCol);

            var currAcceleration = new MatrixCoords(pToAttrRow, pToAttrCol);
            return currAcceleration;
        }
        private static int DecreaseVectorCoordToPower(ParticleAttractor attractor, int pToAttrCoord)
        {
            if (Math.Abs(pToAttrCoord) > attractor.Power)
            {
                pToAttrCoord = (pToAttrCoord / (int)Math.Abs(pToAttrCoord)) * attractor.Power;
            }
            return pToAttrCoord;
        }
    }
}
