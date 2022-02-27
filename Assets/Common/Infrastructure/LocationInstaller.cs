using UnityEngine;
using Zenject;

namespace Common.Infrastructure
{
    public class LocationInstaller: MonoInstaller
    {
        [SerializeField] private Transform _spawnLocation;
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private InventoryDisplay _inventoryDisplay;
        
        
        public override void InstallBindings()
        {
            BindInventory();
            BindHero();
        }

        private void BindInventory()
        {
            Container.Bind<InventoryDisplay>().FromInstance(_inventoryDisplay).AsSingle();
        }

        private void BindHero()
        {
            var playerPrefab =
                Container.InstantiatePrefabForComponent<HeroController>(_playerPrefab, _spawnLocation.position,
                    Quaternion.identity, null);

            Container.Bind<HeroController>().FromInstance(playerPrefab).AsSingle();
        }
    }
}