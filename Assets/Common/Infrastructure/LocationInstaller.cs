using UnityEngine;
using Zenject;

namespace Common.Infrastructure
{
    public class LocationInstaller: MonoInstaller
    {
        [SerializeField] private Transform _spawnLocation;
        [SerializeField] private GameObject _playerPrefab;
        public override void InstallBindings()
        {
            var playerPrefab = 
                Container.InstantiatePrefabForComponent<HeroController>(_playerPrefab, _spawnLocation.position, Quaternion.identity, null);

            Container.Bind<HeroController>().FromInstance(playerPrefab).AsSingle();
        }
    }
}