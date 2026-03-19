using System;
using _Project.Core.Mobs;
using _Project.Core.Stats;

namespace _Project.Core.Abilities
{
    public class AbilityHolder
    {
        private AbilityState _state;
        private int _currentCooldown;

        public Ability Ability { get; set; }
        public int AbilityLevel { get; set; }

        public void Cast(Mob target, StatContainer casterStats) //TODO switch Mob class to FightTargetClass
        {
            if (_state != AbilityState.Ready)
                return;

            Ability.Activate(target, casterStats, AbilityLevel);
            _currentCooldown = Ability.Cooldown;
            _state = AbilityState.Cooldown;
        }

        public void IterateCooldown()
        {
            _currentCooldown = Math.Clamp(_currentCooldown - 1, 0, Ability.Cooldown);

            if (_currentCooldown == 0)
                _state = AbilityState.Ready;
        }
    }

    public enum AbilityState
    {
        Ready,
        Cooldown
    }
}