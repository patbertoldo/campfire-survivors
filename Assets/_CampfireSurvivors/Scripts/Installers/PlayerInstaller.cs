using System;
using UnityEngine;
using Zenject;
using CampfireSurvivors.Player.Movement;

namespace CampfireSurvivors.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField]
        PlayerMovementSettings playerMovementSettings = null;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerMovementPC>().AsSingle().WithArguments(playerMovementSettings);
        }
    }
}