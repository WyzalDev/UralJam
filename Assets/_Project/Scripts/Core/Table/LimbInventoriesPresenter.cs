using System;
using _Project.UI.Table;
using _Project.UI.Table.Inventory;
using _Project.UI.Table.LimbSlots;
using _Project.UI.Table.SetBonuses;
using _Project.UI.Table.SkeletonAbilities;
using _Project.UI.Table.SkeletonStats;
using Zenject;

namespace _Project.Core.Table
{
    public class LimbInventoriesPresenter : IInitializable, IDisposable
    {
        private LimbInventory _limbInventory;
        private SkeletonSwitcher _skeletonSwitcher;
        private SelectedLimbSlot _selectedLimbSlot;

        private InventorySlotsView _inventorySlotsView;
        private SkeletonStatsView _statsView;
        private LimbSlotsView _limbSlotsView;
        private SetBonusesView _setBonusesView;
        private SkeletonAbilitiesView _skeletonAbilitiesView;

        [Inject]
        public LimbInventoriesPresenter(LimbInventory limbInventory, SkeletonSwitcher switcher,
            SelectedLimbSlot selectedLimbSlot, InventorySlotsView inventorySlotsView,
            SkeletonStatsView skeletonStatsView, LimbSlotsView limbSlotsView, SetBonusesView setBonusesView,
            SkeletonAbilitiesView skeletonAbilitiesView)
        {
            _limbInventory = limbInventory;
            _skeletonSwitcher = switcher;
            _selectedLimbSlot = selectedLimbSlot;
            _inventorySlotsView = inventorySlotsView;
            _statsView = skeletonStatsView;
            _limbSlotsView = limbSlotsView;
            _setBonusesView = setBonusesView;
            _skeletonAbilitiesView = skeletonAbilitiesView;
        }

        public void Initialize()
        {
            AddInventorySlotButtonListeners();
            AddLimbSlotButtonListeners();
        }

        private void AddInventorySlotButtonListeners()
        {
            for (var i = 0; i < _inventorySlotsView.Slots.Length; i++)
            {
                var tempIndex = i;
                _inventorySlotsView.Slots[i].Button.onClick.AddListener(() =>
                    OnInventorySlotClicked(tempIndex, _inventorySlotsView.Slots[tempIndex]));
            }
        }

        private void AddLimbSlotButtonListeners()
        {
            for (var i = 0; i < _inventorySlotsView.Slots.Length; i++)
            {
                var tempIndex = i;
                _limbSlotsView.Slots[i].Button.onClick
                    .AddListener(() => OnLimbSlotClicked(_limbSlotsView.Slots[tempIndex].SlotType));
            }
        }

        private void OnInventorySlotClicked(int index, InventorySlotView inventorySlotView)
        {
        }

        private void OnLimbSlotClicked(LimbSlotType type)
        {
        }

        public void Dispose()
        {
            foreach (var slot in _inventorySlotsView.Slots)
                slot.Button.onClick.RemoveAllListeners();

            foreach (var slot in _limbSlotsView.Slots)
                slot.Button.onClick.RemoveAllListeners();
        }
    }
}