using UnityEngine;

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
            if (index < _skeletons.Length && index >= 0)
                return _skeletons[index];

            Debug.Log($"Skeleton {index} out of range, null returned");
            return null;
        }
    }
}