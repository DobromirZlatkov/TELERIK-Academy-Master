using System;
using System.Collections.Generic;
using System.Threading;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private const int MinSpeed = -1;
        private const int MaxSpeed = 1;
        private const int MaxEggsToProducePerTick = 5;
        private const int FreezeAfterMax = 10;
        private const int FreezeTimeMax = 10;
        private int framesFreezedCount;
        private int framesMovingCount;        

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, int freezeAfter, int freezeTime)
            : base(position, speed)
        {
            this.FreezeTime = freezeTime;
            this.FreezeAfter = freezeAfter;
            this.Freezed = false;            
        }
        public int FreezeTime { get; private set; }
        public int FreezeAfter { get; private set; }
        public bool Freezed { get; private set; }
        public bool ProducedEggs { get; private set; }

        public override IEnumerable<Particle> Update()
        {           
            if (this.Freezed)
            {
                this.framesFreezedCount++;
                if (this.framesFreezedCount == this.FreezeTime)
                {
                    this.Freezed = false;
                    this.framesFreezedCount = 0;
                    this.ProducedEggs = false;                          
                }

                List<Particle> produced = new List<Particle>();
                
                if (!this.ProducedEggs)
                {                    
                    for (int i = 0; i <=MaxEggsToProducePerTick; i++)
                    {
                        int row = this.rand.Next(MinSpeed,MaxSpeed+1);
                        int col = this.rand.Next(MinSpeed, MaxSpeed + 1);
                        //Particle p = new ChickenParticle(this.Position, new MatrixCoords(row,col),this.rand.Next(FreezeAfterMax),this.rand.Next(FreezeTimeMax));

                        //if you want to have a better look what`s happening, we`d better create new "ordinary" Particle instead of ChickenParticle
                        
                        Particle p = new Particle(this.Position, new MatrixCoords(row,col));
                        
                        produced.Add(p);                       
                    }
                    
                    var baseProduced = base.Update();
                    produced.AddRange(baseProduced);
                    this.ProducedEggs = true;                    
                    return produced;
                }                   
            }

            this.framesMovingCount++;
            if (this.framesMovingCount == this.FreezeAfter)
            {
                this.Freezed = true;
                this.framesMovingCount = 0;
            }
            return base.Update();
        }

        protected override void Move()
        {
            if (!this.Freezed)
            {
                int row = this.rand.Next(MinSpeed,MaxSpeed+1);
                int col = this.rand.Next(MinSpeed, MaxSpeed + 1);
                this.Position += new MatrixCoords(row, col);
            }
            else
            {
                this.Position += new MatrixCoords(0, 0);
            }

        }
        public override char[,] GetImage()
        {
            return new char[,] { { '9' } };
        }
    }    
}
