using System.Collections.Generic;
using System.Linq;
using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using UnityEngine;
using Zenject;

namespace _Project.UI.Table.LimbSlots
{
    public class LimbSlotsView : MonoBehaviour
    {
        [SerializeField] private LimbSlotView[] _slots;

        public LimbSlotView[] Slots => _slots;

        [Inject]
        private void Construct(HoverLimbWindowManager hoverWindowManager)
        {
            foreach (var slot in _slots)
                slot.SetManager(hoverWindowManager);
        }

        public void RedrawAll(Dictionary<LimbSlotType, LimbViewData> viewData)
        {
            foreach (var limbSlotView in _slots)
                limbSlotView.Redraw(viewData[limbSlotView.SlotType]);
        }

        public void RedrawSelectedSlot(LimbSlotType slotType, LimbViewData viewData)
        {
            _slots.FirstOrDefault(l => l.SlotType == slotType)?.Redraw(viewData);
        }
    }

    public enum LimbSlotType
    {
        Head,
        LeftArm,
        RightArm,
        LeftLeg,
        RightLeg
    }
}