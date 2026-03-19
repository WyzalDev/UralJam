using System;
using _Project.UI.Table;
using Zenject;

namespace _Project.Core.Table
{
    public class SkeletonSwitcherPresenter : IInitializable, IDisposable
    {
        private SkeletonSwitcher _switcher;

        private SkeletonSwitcherView _switcherView;
        private LimbSlotsView _limbSlotView;
        private SetBonusesView _setBonusesView;

        public void Initialize()
        {
            _switcherView.NextSkeletonButton.onClick.AddListener(OnNextButtonClicked);
            _switcherView.PrevSkeletonButton.onClick.AddListener(OnPreviousButtonClicked);
        }

        private void OnNextButtonClicked()
        {
        }

        private void OnPreviousButtonClicked()
        {
        }

        public void Dispose()
        {
            _switcherView.NextSkeletonButton.onClick.RemoveListener(OnNextButtonClicked);
            _switcherView.PrevSkeletonButton.onClick.RemoveListener(OnPreviousButtonClicked);
        }
    }
}