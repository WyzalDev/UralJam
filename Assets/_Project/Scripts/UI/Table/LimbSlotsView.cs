using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table
{
    public class LimbSlotsView : MonoBehaviour
    {
        [SerializeField] private LimbSlotView[] _slots;

        public LimbSlotView[] Slots => _slots;

        public void RedrawAll(Dictionary<LimbSlotType, Sprite> data)
        {
            foreach (var limbSlotView in _slots)
                limbSlotView.Redraw(data[limbSlotView.SlotType]);
        }

        public void RedrawSelectedSlot(LimbSlotType slotType, Sprite icon)
        {
            _slots.FirstOrDefault(l => l.SlotType == slotType)?.Redraw(icon);
        }
    }


    public class LimbSlotView : MonoBehaviour
    {
        [SerializeField] private LimbSlotType _slotType;
        [SerializeField] private Button _button;
        [SerializeField] private Image _image;

        public Button Button => _button;
        public LimbSlotType SlotType => _slotType;

        public void Redraw(Sprite icon)
        {
            _image.sprite = icon;
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