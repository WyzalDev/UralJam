using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using _Project.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table.SetBonuses
{
    public class SetBonusView : MonoBehaviour
    {
        [SerializeField] private Image _image;

        private HoverSetBonusWindowManager _hoverWindowManager;
        private HoverSetBonusWindowData _hoverWindowData;

        public void SetManager(HoverSetBonusWindowManager hoverWindowManager)
        {
            _hoverWindowManager = hoverWindowManager;
        }

        public void Redraw(SetBonusViewData viewData)
        {
            _image.sprite = viewData.Sprite;
            _hoverWindowData = viewData.HoverWindowData;
        }

        public void Hide()
        {
            _image.color = ColorExpanded.Transparent;
        }

        public void Show()
        {
            _image.color = Color.white;
        }
    }

    public class SetBonusViewData
    {
        public Sprite Sprite;
        public HoverSetBonusWindowData HoverWindowData;
    }
}