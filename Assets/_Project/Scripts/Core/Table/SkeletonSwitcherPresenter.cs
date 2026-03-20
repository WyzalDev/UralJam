using System;
using _Project.UI.Table;
using _Project.UI.Table.LimbSlots;
using _Project.UI.Table.SetBonuses;
using _Project.UI.Table.SkeletonAbilities;
using Zenject;

namespace _Project.Core.Table
{
    public class SkeletonSwitcherPresenter : IInitializable, IDisposable
    {
        private SkeletonSwitcher _switcher;

        private SkeletonSwitcherView _switcherView;
        private LimbSlotsView _limbSlotsView;
        private SetBonusesView _setBonusesView;
        private SkeletonAbilityView _abilityView;

        [Inject]
        public SkeletonSwitcherPresenter(SkeletonSwitcher switcher, SkeletonSwitcherView switcherView,
            LimbSlotsView limbSlotsView, SetBonusesView setBonusesView, SkeletonAbilityView abilityView)
        {
            _switcher = switcher;
            _switcherView = switcherView;
            _limbSlotsView = limbSlotsView;
            _setBonusesView = setBonusesView;
            _abilityView = abilityView;
        }

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