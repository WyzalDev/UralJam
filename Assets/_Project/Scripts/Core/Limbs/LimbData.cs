using System;
using _Project.Core.Mobs;
using _Project.Core.Stats;
using UnityEngine;

namespace _Project.Core.Limbs
{
    [CreateAssetMenu(menuName = "Game/LimbData")]
    public class LimbData : ScriptableObject
    {
        [SerializeField] private LimbType _type;
        [SerializeField] private CreatureType _creatureType;
        [SerializeField] private StatData[] _stats;

        public LimbType Type => _type;
        public CreatureType CreatureType => _creatureType;
        public StatData[] Stats => _stats;
    }

    [Serializable]
    public class Limb
    {
        public LimbData Data { get; private set; }

        public StatContainer Stats { get; private set; }

        public Limb(LimbData data)
        {
            Data = data;
            Stats = new StatContainer(data.Stats);
        }
    }

    public enum LimbType
    {
        Head,
        Arm,
        Leg
    }
}