using _Project.UI.HoverWindows.Views;
using UnityEngine;
using Zenject;

namespace _Project.UI.Table.SkeletonStats
{
    public class SkeletonStatsView : MonoBehaviour
    {
        [SerializeField] private SkeletonStatView _hp;
        [SerializeField] private SkeletonStatView _armor;
        [SerializeField] private SkeletonStatView _attack;
        [SerializeField] private SkeletonStatView _critChance;
        [SerializeField] private SkeletonStatView _additionalHitChance;
        [SerializeField] private SkeletonStatView _aoeChance;
        [SerializeField] private SkeletonStatView _mentalDamageChance;
        [SerializeField] private SkeletonStatView _stability;

        [Inject]
        private void Construct(HoverStatWindowManager hoverWindowManager)
        {
            _hp.SetManager(hoverWindowManager);
            _armor.SetManager(hoverWindowManager);
            _attack.SetManager(hoverWindowManager);
            _critChance.SetManager(hoverWindowManager);
            _additionalHitChance.SetManager(hoverWindowManager);
            _aoeChance.SetManager(hoverWindowManager);
            _mentalDamageChance.SetManager(hoverWindowManager);
            _stability.SetManager(hoverWindowManager);
        }

        public void Redraw(StatContainerData data)
        {
            _hp.Redraw(data.Hp);
            _armor.Redraw(data.Armor);
            _attack.Redraw(data.Attack);
            _critChance.Redraw(data.CritChance);
            _additionalHitChance.Redraw(data.AdditionalHitChance);
            _aoeChance.Redraw(data.AoeChance);
            _mentalDamageChance.Redraw(data.MentalDamageChance);
            _stability.Redraw(data.Stability);
        }
    }
}