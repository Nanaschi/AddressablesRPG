using UnityEngine;
using Zenject;

namespace Common.Infrastructure
{
    public class LocationInstaller: MonoInstaller
    {
        [SerializeField] private Transform _spawnLocation;
        [SerializeField] private HeroController _playerPrefab;
        public override void InstallBindings()
        {
            
        }
    }
}