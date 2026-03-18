using System;

namespace _Project.Core.Stats
{
    [Serializable]
    public class StatContainer
    {
        public int Hp;
        public int Armor;
        public int Attack;
        public float CritChance;
        public float AdditionalHitChance;
        public float AoeChance;
        public float MentalDamageChance;
        public float Stability;

        public StatContainer(int hp, int armor, int attack, float critChance, float additionalHitChance,
            float aoeChance, float mentalDamageChance, float stability)
        {
            Hp = hp;
            Armor = armor;
            Attack = attack;
            CritChance = critChance;
            AdditionalHitChance = additionalHitChance;
            AoeChance = aoeChance;
            MentalDamageChance = mentalDamageChance;
            Stability = stability;
        }

        public void Reset()
        {
            Hp = 0;
            Armor = 0;
            Attack = 0;
            CritChance = 0;
            AdditionalHitChance = 0;
            AoeChance = 0;
            MentalDamageChance = 0;
            Stability = 0;
        }
    }

    [Serializable]
    public class StatUpgrades
    {
        public int HpCount;
        public int ArmorCount;
        public int AttackCount;
        public int CritChanceCount;
        public int AdditionalHitChanceCount;
        public int AoeChanceCount;
        public int MentalDamageChanceCount;
        public int StabilityCount;

        public void Reset()
        {
            HpCount = 0;
            ArmorCount = 0;
            AttackCount = 0;
            CritChanceCount = 0;
            AdditionalHitChanceCount = 0;
            AoeChanceCount = 0;
            MentalDamageChanceCount = 0;
            StabilityCount = 0;
        }
    }
}