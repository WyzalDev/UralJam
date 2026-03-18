using System;
using _Project.Core.Limbs;
using _Project.Core.Stats;
using _Project.UI.Limbs;
using UnityEngine;

namespace _Project.Core.Mobs
{
    public class Skeleton
    {
        private Limb _head;
        private Limb _rightArm;
        private Limb _leftArm;
        private Limb _rightLeg;
        private Limb _leftLeg;
        private StatContainer _stats;
        private StatUpgrades _statUpgrades;
        private CreatureType[] _setBonuses;

        public Skeleton(Limb head, Limb rightArm, Limb leftArm, Limb rightLeg, Limb leftLeg)
        {
            _head = head;
            _rightArm = rightArm;
            _leftArm = leftArm;
            _rightLeg = rightLeg;
            _leftLeg = leftLeg;
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