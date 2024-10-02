namespace Quantum.TestTask
{
    public unsafe class EnemySpawnSystem : SystemMainThreadFilter<EnemySpawnSystem.Filter>
    {
        public override void Update(Frame f, ref Filter filter)
        {

        }

        public struct Filter
        {
            public EntityRef Entity;
            public Enemy* Enemy;
        }
    }
}