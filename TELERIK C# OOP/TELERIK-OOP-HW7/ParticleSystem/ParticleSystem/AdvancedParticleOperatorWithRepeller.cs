using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class AdvancedParticleOperatorWithRepeller : AdvancedParticleOperator
    {
        private List<ParticleRepeller> repellersCurrFrame = new List<ParticleRepeller>();
        private List<Particle> particles = new List<Particle>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var repellerCandidate = p as ParticleRepeller;
            if (repellerCandidate == null)
            {
                this.particles.Add(p);
            }
            else
            {
                this.repellersCurrFrame.Add(repellerCandidate);
            }
            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var repeller in this.repellersCurrFrame)
            {
                foreach (var particle in this.particles)
                {
                    var currAcceleration = GetRepelledFromParticleAttractor(repeller, particle);

                    particle.Accelerate(currAcceleration);
                }
            }
            this.repellersCurrFrame.Clear();
            this.particles.Clear();
            base.TickEnded();
        }
        
        private static MatrixCoords GetRepelledFromParticleAttractor(ParticleRepeller repeller, Particle particle)
        {
            var currParticleToRepellerVector = repeller.Position - particle.Position;

            int pToAttrRow = currParticleToRepellerVector.Row;
            pToAttrRow = DecreaseVectorCoordToPower(repeller, pToAttrRow);

            int pToAttrCol = currParticleToRepellerVector.Col;
            pToAttrCol = DecreaseVectorCoordToPower(repeller, pToAttrCol);

            var currRepell = new MatrixCoords(-pToAttrRow, -pToAttrCol);
            return currRepell;
        }

        private static int DecreaseVectorCoordToPower(ParticleRepeller attractor, int pToAttrCoord)
        {
            if (Math.Abs(pToAttrCoord) > attractor.Power)
            {
                pToAttrCoord = (pToAttrCoord / (int)Math.Abs(pToAttrCoord)) * attractor.Power;
            }
            return pToAttrCoord;
        }
    }
}
