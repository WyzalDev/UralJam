using System.Collections.Generic;
using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using UnityEngine;
using Zenject;

namespace _Project.UI.Table.SetBonuses
{
    public class SetBonusesView : MonoBehaviour
    {
        [SerializeField] private SetBonusView[] _setBonuses;

        [Inject]
        private void Construct(HoverSetBonusWindowManager hoverWindowManager)
        {
            foreach (var slot in _setBonuses)
                slot.SetManager(hoverWindowManager);
        }

        public void Redraw(List<SetBonusViewData> viewsData)
        {
            foreach (var setBonusView in _setBonuses)
                setBonusView.Hide();

            var index = 0;
            while (index < _setBonuses.Length)
            {
                if (index < viewsData.Count)
                    break;

                _setBonuses[index].Redraw(viewsData[index]);
                _setBonuses[index].Show();
                index++;
            }
        }
    }
}