using System;
using _Project.Core.Stats;
using TMPro;
using UnityEngine;

namespace _Project.UI.Table
{
    public class SkeletonStatsView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _hp;
        [SerializeField] private TMP_Text _armor;
        [SerializeField] private TMP_Text _attack;
        [SerializeField] private TMP_Text _critChance;
        [SerializeField] private TMP_Text _additionalHitChance;
        [SerializeField] private TMP_Text _aoeChance;
        [SerializeField] private TMP_Text _mentalDamageChance;
        [SerializeField] private TMP_Text _stability;

        public void Redraw(StatContainerData data)
        {
            _hp.text = data.Hp;
            _armor.text = data.Armor;
            _attack.text = data.Attack;
            _critChance.text = data.CritChance;
            _additionalHitChance.text = data.AdditionalHitChance;
            _aoeChance.text = data.AoeChance;
            _mentalDamageChance.text = data.MentalDamageChance;
            _stability.text = data.Stability;
        }
    }

    [Serializable]
    public class StatContainerData
    {
        public string Hp;
        public string Armor;
        public string Attack;
        public string CritChance;
        public string AdditionalHitChance;
        public string AoeChance;
        public string MentalDamageChance;
        public string Stability;

        public void SetStatsContainerData(StatContainer container)
        {
            Hp = $"{container.Hp}";
            Armor = $"{container.Armor}";
            Attack = $"{container.Attack}";
            CritChance = $"{container.CritChance}";
            AdditionalHitChance = $"{container.AdditionalHitChance}";
            AoeChance = $"{container.AoeChance}";
            MentalDamageChance = $"{container.MentalDamageChance}";
            Stability = $"{container.Stability}";
        }
    }
}