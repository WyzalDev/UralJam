namespace _Project.Core.Mobs
{
    public class SkeletonSquad
    {
        private Skeleton[] _skeletons;

        private int _skeletonsCount;

        public SkeletonSquad(Skeleton[] skeletons)
        {
            _skeletons = skeletons;
            _skeletonsCount = skeletons.Length;
        }

        public Skeleton GetSkeletonByIndex(int index)
        {
            return _skeletons[index];
        }
    }
}