using _Project.Core.Abilities;
using _Project.Core.Limbs;
using _Project.Core.Stats;

namespace _Project.Core.Mobs
{
    public class Mob
    {
        protected Limb _head;
        protected Limb _rightArm;
        protected Limb _leftArm;
        protected Limb _rightLeg;
        protected Limb _leftLeg;
        protected CreatureType[] _setBonuses;
        protected StatContainer _stats;
        protected Ability[] abilities;

        public Mob(Limb head, Limb rightArm, Limb leftArm, Limb rightLeg, Limb leftLeg)
        {
            _head = head;
            _rightArm = rightArm;
            _leftArm = leftArm;
            _rightLeg = rightLeg;
            _leftLeg = leftLeg;
            _setBonuses = new CreatureType[3];
            abilities = new Ability[3];
            _stats = new StatContainer();
        }

        public void Recalculate()
        {
            RecalculateSetBonuses();
            RecalculateStats();
            RecalculateAbilities();
        }

        protected virtual void RecalculateStats()
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