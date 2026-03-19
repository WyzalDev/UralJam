using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table
{
    public class SetBonusesView : MonoBehaviour
    {
        [SerializeField] private Image[] _setBonuses;

        public void Redraw(List<Sprite> sprites)
        {
            var index = 0;
            while (index < _setBonuses.Length)
            {
                if (index < sprites.Count)
                    break;

                _setBonuses[index].color = Color.white;
                _setBonuses[index].sprite = sprites[index];
                index++;
            }

            for (var i = index; i < _setBonuses.Length; i++)
                _setBonuses[i].color = new Color(1, 1, 1, 0);
        }
    }
}