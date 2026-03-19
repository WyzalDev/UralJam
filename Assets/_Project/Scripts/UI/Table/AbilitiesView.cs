using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table
{
    public class AbilitiesView : MonoBehaviour
    {
        [SerializeField] private AbilityView[] _abilities;

        public void Redraw(List<Sprite> icons)
        {
            var index = 0;
            while (index < _abilities.Length)
            {
                if (index < icons.Count)
                    break;

                _abilities[index].Show();
                _abilities[index].Redraw(icons[index]);
                index++;
            }

            for (var i = index; i < _abilities.Length; i++)
                _abilities[i].Hide();
        }
    }

    public class AbilityView : MonoBehaviour
    {
        [SerializeField] private Image _image;

        private static readonly Color Transparent = new Color(1, 1, 1, 0);

        public void Redraw(Sprite icon)
        {
            _image.sprite = icon;
        }

        public void Hide()
        {
            _image.color = Transparent;
        }

        public void Show()
        {
            _image.color = Color.white;
        }
    }
}