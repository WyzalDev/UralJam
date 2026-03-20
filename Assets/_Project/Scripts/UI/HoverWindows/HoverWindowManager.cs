using UnityEngine;

namespace _Project.UI.HoverWindows
{
    public abstract class HoverWindowManager : MonoBehaviour
    {
        [SerializeField] protected HoverWindowView _hoverWindow;

        public void ShowWindow(HoverWindowData data)
        {
             _hoverWindow.Show(data);
        }

        public void HideWindow(HoverWindowData data)
        {
            _hoverWindow.Hide();
        }
    }
}