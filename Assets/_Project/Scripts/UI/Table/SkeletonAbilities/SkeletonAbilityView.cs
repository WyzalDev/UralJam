using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using _Project.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table.SkeletonAbilities
{
    public class SkeletonAbilityView : MonoBehaviour
    {
        [SerializeField] private Image _image;

        private HoverAbilityWindowManager _hoverWindowManager;
        private HoverAbilityWindowData _hoverWindowData;

        public void SetManager(HoverAbilityWindowManager hoverWindowManager)
        {
            _hoverWindowManager = hoverWindowManager;
        }

        public void Redraw(SkeletonAbilityViewData viewData)
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

    public class SkeletonAbilityViewData
    {
        public Sprite Sprite;
        public HoverAbilityWindowData HoverWindowData;
    }
}