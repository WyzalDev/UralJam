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
        protected StatContainer _stats;

        public Mob(Limb head, Limb rightArm, Limb leftArm, Limb rightLeg, Limb leftLeg)
        {
            _head = head;
            _rightArm = rightArm;
            _leftArm = leftArm;
            _rightLeg = rightLeg;
            _leftLeg = leftLeg;
        }
    }
}