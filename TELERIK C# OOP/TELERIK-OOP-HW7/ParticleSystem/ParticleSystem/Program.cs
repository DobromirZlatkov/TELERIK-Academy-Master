using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class Program
    {
        const int Rows = 30;
        const int Cols = 30;
        static readonly Random RandomGenerator = new Random();
        static void Main(string[] args)
        {
            var render = new ConsoleRenderer(Rows, Cols);
            var particleOperator = new AdvancedParticleOperator();
            var engine = new Engine(render, particleOperator,null,300);            
            GenerateInitialData(engine);
            engine.Run();

        }

        private static void GenerateInitialData(Engine engine)
        {
            //Ordinary particle -----------------

            engine.AddParticle(
                new Particle(
                    new MatrixCoords(10, 10),
                    new MatrixCoords(1, 0)
                    )
                );

            //Dying Particle -----------------

            //engine.AddParticle(
            //    new DyingParticle(
            //        new MatrixCoords(20, 5),
            //        new MatrixCoords(-1, 1), 6
            //        )
            //    );

            //Particle Emitter ------------------
            var emitterPosition = new MatrixCoords(25,3);
            var emitterSpeed = new MatrixCoords(0,0);
            var emitter = new ParticleEmitter(emitterPosition, emitterSpeed,
                RandomGenerator,
                1,//count of emitter particles per thick
                2,
                GenerateRandomParticle
                );
            //engine.AddParticle(emitter);


            //Attractors ----------------------
            var attractorPosition = new MatrixCoords(15,15);
            var attractor = new ParticleAttractor(attractorPosition,
                new MatrixCoords(0, 0),
                int.MaxValue);
            var attractorPosition2 = new MatrixCoords(10, 13);
            var attractor2 = new ParticleAttractor(attractorPosition2,
                new MatrixCoords(0, 0),
                3);
            engine.AddParticle(attractor);
            //engine.AddParticle(attractor2);

            //CHAOTIC PARTICLE (THAT CHANGES ITS DIRECTION AND SPEED)
            var chaoticParticlePosition = new MatrixCoords(10, 10);
            var chaoticParticleSpeed = new MatrixCoords(1, 1);
            var chaoticParticle = new ChaoticParticle(chaoticParticlePosition, chaoticParticleSpeed);
            engine.AddParticle(chaoticParticle);


            //var achaoticParticlePosition = new MatrixCoords(5, 5);
            //var achaoticParticleSpeed = new MatrixCoords(1, 1);
            //var achaoticParticle = new ChaoticParticle(achaoticParticlePosition, achaoticParticleSpeed);
            //engine.AddParticle(achaoticParticle);

            //var aachaoticParticlePosition = new MatrixCoords(18, 7);
            //var aachaoticParticleSpeed = new MatrixCoords(1, 1);
            //var aachaoticParticle = new ChaoticParticle(aachaoticParticlePosition, aachaoticParticleSpeed);
            //engine.AddParticle(aachaoticParticle);



            //CHICKEN PARTICLE
            var chickenParticlePosition = new MatrixCoords(15, 15);
            var chickenParticleSpeed = new MatrixCoords(0, 0);
            var chickenParticle = new ChickenParticle(chickenParticlePosition, chickenParticleSpeed,10, 5);
            //engine.AddParticle(chickenParticle);

            //PARTICLE REPELLER
            var repellerPosition = new MatrixCoords(28, 15);
            var repellerSpeed = new MatrixCoords(0,0);
            var repeller = new ParticleRepeller(repellerPosition, repellerSpeed,1);
            //engine.AddParticle(repeller);
        }
        static Particle GenerateRandomParticle(ParticleEmitter emitterParam)
        {
            MatrixCoords particlePos = emitterParam.Position;
            int particleRowSpeed = emitterParam.RandomGenerator.Next(emitterParam.MinSpeedCoord, emitterParam.MaxSpeedCoord + 1);
            int particleColSpeed = emitterParam.RandomGenerator.Next(emitterParam.MinSpeedCoord, emitterParam.MaxSpeedCoord + 1);
            MatrixCoords particleSpeed = new MatrixCoords(particleRowSpeed, particleColSpeed);
            Particle generated = null;
            int particleTypeIndex = emitterParam.RandomGenerator.Next(0, 2);
            switch (particleTypeIndex)
            {
                case 0: generated = new Particle(particlePos, particleSpeed); break;
                case 1:
                    uint lifespan = (uint)emitterParam.RandomGenerator.Next(0, 8);
                    generated = new DyingParticle(particlePos, particleSpeed, lifespan); break;
                default:
                    throw new Exception("No such particle type index");
                    break;
            }
            return generated;
        }
    }
}
