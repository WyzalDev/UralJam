using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using _Project.UI.Table.LimbSlots;
using UnityEngine;
using Zenject;

namespace _Project.UI.Table.Inventory
{
    public class InventorySlotsView : MonoBehaviour
    {
        [SerializeField] private InventorySlotView[] _slots;

        public InventorySlotView[] Slots => _slots;

        [Inject]
        private void Construct(HoverLimbWindowManager limbWindowManager)
        {
            foreach (var slot in _slots)
                slot.SetManager(limbWindowManager);
        }

        public void Redraw(LimbViewData[] viewsData)
        {
            for (var i = 0; i < _slots.Length; i++)
                _slots[i].Redraw(viewsData[i]);
        }
    }
}