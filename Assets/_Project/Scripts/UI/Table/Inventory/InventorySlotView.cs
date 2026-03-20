using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using _Project.UI.Table.LimbSlots;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table.Inventory
{
    public class InventorySlotView : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Button _button;

        private HoverLimbWindowManager _hoverWindowManager;
        private HoverLimbWindowData _hoverWindowData;

        public Button Button => _button;

        public void SetManager(HoverLimbWindowManager hoverWindowManager)
        {
            _hoverWindowManager = hoverWindowManager;
        }

        public void Redraw(LimbViewData viewData)
        {
            _image.sprite = viewData.Sprite;
            _hoverWindowData = viewData.HoverWindowData;
        }
    }
}