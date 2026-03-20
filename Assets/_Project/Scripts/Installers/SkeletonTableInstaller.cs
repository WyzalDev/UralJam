using System.Collections.Generic;
using _Project.Core.Limbs;
using _Project.Core.Mobs;
using _Project.Core.Table;
using _Project.UI.HoverWindows.Managers;
using _Project.UI.HoverWindows.Views;
using _Project.UI.Table;
using _Project.UI.Table.Inventory;
using _Project.UI.Table.LimbSlots;
using _Project.UI.Table.SetBonuses;
using _Project.UI.Table.SkeletonAbilities;
using _Project.UI.Table.SkeletonStats;
using UnityEngine;
using Zenject;

namespace _Project.Installers
{
    public class SkeletonTableInstaller : MonoInstaller
    {
        [Header("Limb Data")]
        [SerializeField] private LimbsInstallData _limbsInstallData;
        [SerializeField] private LimbInventoryData _limbInventoryData;
        
        [Header("Hover Window Managers")]
        [SerializeField] private HoverStatWindowManager _hoverStatWindowManager;
        [SerializeField] private HoverLimbWindowManager _hoverLimbWindowManager;
        [SerializeField] private HoverSetBonusWindowManager _hoverSetBonusWindowManager;
        [SerializeField] private HoverAbilityWindowManager _hoverAbilityWindowManager;
        
        [Header("Views")]
        [SerializeField] private SkeletonStatsView _skeletonStatsView;
        [SerializeField] private InventorySlotsView _inventorySlotsView;
        [SerializeField] private LimbSlotsView _limbSlotsView;
        [SerializeField] private SkeletonSwitcherView _skeletonSwitcherView;
        [SerializeField] private SetBonusesView _setBonusesView;
        [SerializeField] private SkeletonAbilitiesView _skeletonAbilitiesView;

        private Dictionary<LimbKey, LimbData> limbsDataDictionary;

        public override void InstallBindings()
        {
            InstallLimbsDictionary();
            InstallSkeletonSquad();

            InstallModel();
            InstallHoverWindowManagers();
            InstallView();
            InstallPresenters();
        }

        private void InstallLimbsDictionary()
        {
            limbsDataDictionary = _limbsInstallData.GenerateLimbsDictionary();
            Container.BindInstance(limbsDataDictionary).AsSingle().NonLazy();
        }

        private void InstallSkeletonSquad()
        {
            var defaultHeadKey = new LimbKey(CreatureType.Skeleton, LimbType.Head);
            var defaultArmKey = new LimbKey(CreatureType.Skeleton, LimbType.Arm);
            var defaultLegKey = new LimbKey(CreatureType.Skeleton, LimbType.Leg);

            var skeletons = new Skeleton[3];
            for (var i = 0; i < skeletons.Length; i++)
            {
                var skeleton = new Skeleton(new Limb(limbsDataDictionary[defaultHeadKey]),
                    new Limb(limbsDataDictionary[defaultArmKey]), new Limb(limbsDataDictionary[defaultArmKey]),
                    new Limb(limbsDataDictionary[defaultLegKey]), new Limb(limbsDataDictionary[defaultLegKey]));

                skeleton.Recalculate();
                skeletons[i] = skeleton;
            }

            var skeletonSquad = new SkeletonSquad(skeletons);
            Container.BindInstance(skeletonSquad).AsSingle().NonLazy();
        }

        private void InstallModel()
        {
            Container.Bind<SkeletonSwitcher>().ToSelf().AsSingle();
            Container.Bind<SelectedLimbSlot>().ToSelf().AsSingle();
            Container.Bind<LimbInventory>().ToSelf().AsSingle().WithArguments(_limbInventoryData);
        }

        private void InstallHoverWindowManagers()
        {
            Container.BindInstance(_hoverStatWindowManager).AsSingle();
            Container.BindInstance(_hoverLimbWindowManager).AsSingle();
            Container.BindInstance(_hoverSetBonusWindowManager).AsSingle();
            Container.BindInstance(_hoverAbilityWindowManager).AsSingle();
        }

        private void InstallView()
        {
            Container.BindInstance(_skeletonStatsView).AsSingle();
            Container.BindInstance(_inventorySlotsView).AsSingle();
            Container.BindInstance(_limbSlotsView).AsSingle();
            Container.BindInstance(_skeletonSwitcherView).AsSingle();
            Container.BindInstance(_setBonusesView).AsSingle();
            Container.BindInstance(_skeletonAbilitiesView).AsSingle();
        }

        private void InstallPresenters()
        {
            Container.BindInterfacesAndSelfTo<SkeletonSwitcherPresenter>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<LimbInventoriesPresenter>().AsSingle().NonLazy();
        }
    }
}