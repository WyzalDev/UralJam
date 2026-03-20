using _Project.Core.Mobs;
using Zenject;

namespace _Project.Core.Table
{
    public class SkeletonSwitcher
    {
        private Skeleton _selectedSkeleton;
        private int _selectedSkeletonIndex;
        private readonly SkeletonSquad _skeletonSquad;

        [Inject]
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