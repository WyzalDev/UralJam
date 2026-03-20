using System;
using System.Collections.Generic;
using _Project.Core.Mobs;
using UnityEngine;

namespace _Project.Core.Limbs
{
    [Serializable]
    public class LimbsInstallData
    {
        [SerializeField] private LimbData[] _limbs;

        public Dictionary<LimbKey, LimbData> GenerateLimbsDictionary()
        {
            var dictionary = new Dictionary<LimbKey, LimbData>();

            foreach (var limb in _limbs)
            {
                var limbKey = new LimbKey(limb.CreatureType, limb.Type);

                if (dictionary.TryAdd(limbKey, limb))
                    continue;

                Debug.LogWarning($"Limb {limbKey.CreatureType} has already been generated");
            }
            
            return dictionary;
        }
    }

    [Serializable]
    public class LimbKey
    {
        public readonly CreatureType CreatureType;
        public readonly LimbType LimbType;

        public LimbKey(CreatureType creatureType, LimbType limbType)
        {
            CreatureType = creatureType;
            LimbType = limbType;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LimbKey);
        }

        public bool Equals(LimbKey other)
        {
            if (other == null)
                return false;
            
            return other.CreatureType == CreatureType && other.LimbType == LimbType && GetHashCode() == other.GetHashCode();
        }

        public override int GetHashCode()
        {
            return (int)LimbType * 10 + (int)CreatureType;
        }
    }
}