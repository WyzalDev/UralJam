using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table
{
    public class InventorySlotsView : MonoBehaviour
    {
        [SerializeField] private InventorySlotView[] _slots;

        public InventorySlotView[] Slots => _slots;

        public void Redraw(Sprite[] sprites)
        {
            for (var i = 0; i < _slots.Length; i++)
                _slots[i].Redraw(sprites[i]);
        }
    }


    public class InventorySlotView : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Button _button;

        public Button Button => _button;

        public void Redraw(Sprite sprite)
        {
            _image.sprite = sprite;
        }
    }
}