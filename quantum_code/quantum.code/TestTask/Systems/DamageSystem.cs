using Photon.Deterministic;

namespace Quantum.TestTask
{
    public unsafe class DamageSystem : SystemMainThread<DamageSystem.Filter>
    {
        public override void Update(Frame frame, ref Filter filter)
        {
            var enemies = frame.Filter<Transform3D, Enemy>();

            while (enemies.NextUnsafe(out var enemyEntity, out var enemyTransform, out var enemy))
            {
                FPVector2 sourcePosition = filter.Transform->Position.XZ;

                FP distanceSquared = FPVector2.DistanceSquared(enemyTransform->Position.XZ, sourcePosition);
            }


                Input input = default;

            filter.Transform->Position.XZ - enemies.Transform


            filter.CharacterController->Move(f, filter.Entity, input.Direction.XOY);
        }

        public struct Filter
        {
            public EntityRef Entity;
            public DamageMaker* DamageMaker;
            public Transform3D* Transform;
        }
    }
}