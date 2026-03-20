using System;
using _Project.Core.Stats;
using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using TMPro;
using UnityEngine;

namespace _Project.UI.Table.SkeletonStats
{
    public class SkeletonStatView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _value;
        [SerializeField] private HoverStatWindowData _hoverWindowData;

        private HoverStatWindowManager _hoverManager;

        public void SetManager(HoverStatWindowManager hoverManager)
        {
            _hoverManager = hoverManager;
        }

        public void Redraw(string statValue)
        {
            _value.text = statValue;
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