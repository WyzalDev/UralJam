using _Project.UI.Table;
using _Project.UI.Table.LimbSlots;

namespace _Project.Core.Table
{
    public class SelectedLimbSlot
    {
        public LimbSlotType SlotType { get; private set; }

        public void SelectNewSlot(LimbSlotType slotType)
        {
            SlotType = slotType;
        }
    }
}