using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table.LimbSlots
{
    public class LimbSlotView : MonoBehaviour
    {
        [SerializeField] private LimbSlotType _slotType;
        [SerializeField] private Button _button;
        [SerializeField] private Image _image;

        private HoverLimbWindowManager _hoverWindowManager;
        private HoverLimbWindowData _hoverWindowData;

        public Button Button => _button;
        public LimbSlotType SlotType => _slotType;

        public void SetManager(HoverLimbWindowManager limbWindowManager)
        {
            _hoverWindowManager = limbWindowManager;
        }

        public void Redraw(LimbViewData viewData)
        {
            _image.sprite = viewData.Sprite;
            _hoverWindowData = viewData.HoverWindowData;
        }
    }

    public class LimbViewData
    {
        public Sprite Sprite;
        public HoverLimbWindowData HoverWindowData;
    }
}