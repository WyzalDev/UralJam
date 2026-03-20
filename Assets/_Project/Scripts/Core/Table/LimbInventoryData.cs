using System;
using System.Collections.Generic;
using _Project.Core.Limbs;
using UnityEngine;

namespace _Project.Core.Table
{
    [Serializable]
    public class LimbInventoryData
    {
        public int SlotsCountForEachInventory;
    }


    public class LimbInventory
    {
        private readonly LimbInventoryData _data;
        private Dictionary<LimbType, Limb[]> _inventories;

        public Limb[] SelectedInventory { get; private set; }

        public LimbInventory(LimbInventoryData data)
        {
            _data = data;
            SetInventories();
        }

        public void SwitchSelectedInventory(LimbType type)
        {
            SelectedInventory = _inventories[type];
        }

        public void AddToInventory(List<Limb> loot)
        {
            foreach (var limb in loot)
            {
                _inventories.TryGetValue(limb.Data.Type, out var limbs);

                if (limbs != null)
                {
                    for (var i = 0; i < limbs.Length; i++)
                    {
                        if (limbs[i] != null)
                            continue;

                        limbs[i] = limb;
                        break;
                    }

                    Debug.Log($"Limb {limb.Data.Type} in loot nowhere to put in inventory");
                }
                else
                    Debug.LogWarning($"{limb.Data.Type} inventory didnt exists");
            }
        }

        public void RemoveFromSelectedInventory(int index)
        {
            for (var i = SelectedInventory.Length - 1; i >= index; i--)
                (SelectedInventory[i], SelectedInventory[i - 1]) = (SelectedInventory[i - 1], SelectedInventory[i]);

            SelectedInventory[^1] = null;
        }

        public void Reset()
        {
            SelectedInventory = null;
            foreach (var inventory in _inventories.Values)
            {
                for (var i = 0; i < inventory.Length; i++)
                    inventory[i] = null;
            }
        }

        private void SetInventories()
        {
            _inventories = new Dictionary<LimbType, Limb[]>
            {
                { LimbType.Arm, new Limb[_data.SlotsCountForEachInventory] },
                { LimbType.Leg, new Limb[_data.SlotsCountForEachInventory] },
                { LimbType.Head, new Limb[_data.SlotsCountForEachInventory] }
            };
        }
    }
}