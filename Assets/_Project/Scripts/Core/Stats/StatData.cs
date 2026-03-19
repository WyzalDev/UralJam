using System;
using UnityEngine;

namespace _Project.Core.Stats
{
    [Serializable]
    public class StatData
    {
        [SerializeField] private StatType _statType;
        [SerializeField] private float _value;

        public StatType StatType => _statType;
        public float Value => _value;
    }

    public enum StatType
    {
        Hp,
        Armor,
        Attack,
        CritChance,
        AdditionalHitChance,
        AoeChance,
        MentalDamageChance
    }
}