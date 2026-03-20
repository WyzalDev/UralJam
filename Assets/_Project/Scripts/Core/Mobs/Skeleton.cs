using System;
using _Project.Core.Abilities;
using _Project.Core.Limbs;
using _Project.Core.Stats;
using _Project.UI.Table;
using _Project.UI.Table.LimbSlots;
using UnityEngine;

namespace _Project.Core.Mobs
{
    public class Skeleton : Mob
    {
        private StatUpgrades _statUpgrades;

        public Skeleton(Limb head, Limb rightArm, Limb leftArm, Limb rightLeg, Limb leftLeg) : base(head, rightArm,
            leftArm, rightLeg, leftLeg)
        {
            _statUpgrades = new StatUpgrades();
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

            Recalculate();
        }

        protected override void RecalculateStats()
        {
        }
    }
}