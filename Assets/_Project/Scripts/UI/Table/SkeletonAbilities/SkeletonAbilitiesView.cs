using System.Collections.Generic;
using _Project.UI.HoverWindows.Managers;
using UnityEngine;
using Zenject;

namespace _Project.UI.Table.SkeletonAbilities
{
    public class SkeletonAbilitiesView : MonoBehaviour
    {
        [SerializeField] private SkeletonAbilityView[] _abilities;

        [Inject]
        private void Construct(HoverAbilityWindowManager hoverWindowManager)
        {
            foreach (var ability in _abilities)
                ability.SetManager(hoverWindowManager);
        }

        public void Redraw(List<SkeletonAbilityViewData> viewDatas)
        {
            var index = 0;
            while (index < _abilities.Length)
            {
                if (index < viewDatas.Count)
                    break;

                _abilities[index].Show();
                _abilities[index].Redraw(viewDatas[index]);
                index++;
            }

            for (var i = index; i < _abilities.Length; i++)
                _abilities[i].Hide();
        }
    }

}