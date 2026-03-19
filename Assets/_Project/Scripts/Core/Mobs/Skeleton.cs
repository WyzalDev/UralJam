using System;
using _Project.Core.Abilities;
using _Project.Core.Limbs;
using _Project.Core.Stats;
using _Project.UI.Table;
using UnityEngine;

namespace _Project.Core.Mobs
{
    public class Skeleton : Mob
    {
        private StatUpgrades _statUpgrades;
        private CreatureType[] _setBonuses;
        private Ability[] _abilities;

        public Skeleton(Limb head, Limb rightArm, Limb leftArm, Limb rightLeg, Limb leftLeg) : base(head, rightArm,
            leftArm, rightLeg, leftLeg)
        {
            _setBonuses = new CreatureType[3];
            _abilities = new Ability[3];
        }

        public void SwitchLimb(LimbSlotType slotType, Limb limb)
        {
            switch (slotType)
            {
                case LimbSlotType.Head:
                    _head = limb;
                    break;
                case LimbSlotType.LeftArm:
                    _leftArm = limb;
                    break;
                case LimbSlotType.RightArm:
                    _rightArm = limb;
                    break;
                case LimbSlotType.LeftLeg:
                    _leftLeg = limb;
                    break;
                case LimbSlotType.RightLeg:
                    _rightLeg = limb;
                    break;
                default:
                    Debug.Log("Undefined slot type");
                    break;
            }

            RecalculateSetBonuses();
            RecalculateStats();
            RecalculateAbilities();
        }

        private void RecalculateStats()
        {
        }

        private void RecalculateSetBonuses()
        {
        }

        private void RecalculateAbilities()
        {
        }
    }
}