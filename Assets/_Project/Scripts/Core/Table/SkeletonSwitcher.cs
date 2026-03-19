using _Project.Core.Mobs;

namespace _Project.Core.Table
{
    public class SkeletonSwitcher
    {
        private Skeleton _selectedSkeleton;
        private int _selectedSkeletonIndex;
        private SkeletonSquad _skeletonSquad;

        public SkeletonSwitcher(SkeletonSquad skeletonSquad)
        {
            _skeletonSquad = skeletonSquad;
        }

        public void ChooseNextSkeleton()
        {
        }

        public void ChoosePreviousSkeleton()
        {
        }

        public void SelectFirstSkeleton()
        {
            _selectedSkeletonIndex = 0;
            _selectedSkeleton = _skeletonSquad.GetSkeletonByIndex(_selectedSkeletonIndex);
        }
    }
}