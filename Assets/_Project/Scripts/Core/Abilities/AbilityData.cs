using _Project.Core.Mobs;
using _Project.Core.Stats;
using UnityEngine;

namespace _Project.Core.Abilities
{
    public abstract class Ability : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private string _formatDescription;
        [SerializeField] private Sprite _icon;
        [SerializeField] private int _cooldown;

        public string Name => _name;
        public string Description => _formatDescription;
        public Sprite Icon => _icon;
        public int Cooldown => _cooldown;

        public abstract void Activate(Mob target, StatContainer casterStats, int abilityLevel);
        //TODO switch Mob class to FightTargetClass
    }
}