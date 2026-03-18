namespace _Project.Core.Mobs
{
    public class SkeletonContainer
    {
        private Skeleton[] _skeletons;

        public Skeleton GetSkeletonByIndex(int index)
        {
            return _skeletons[index];
        }
    }
}