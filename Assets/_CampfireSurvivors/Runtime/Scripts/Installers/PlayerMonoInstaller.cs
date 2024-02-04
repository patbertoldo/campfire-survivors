using System;
using UnityEngine;
using Zenject;
using CampfireSurvivors.Player;
using CampfireSurvivors;

public class PlayerMonoInstaller : MonoInstaller
{
    [SerializeField]
    Settings settings = null;

    private PlayerInputControls controls;

    public override void InstallBindings()
    {
        controls = new PlayerInputControls();

        Container.Bind<Player>().AsSingle()
            .WithArguments(controls, settings.Rigidbody, settings.SpriteRenderer);

        Container.BindInterfacesTo<PlayerMovement>().AsSingle()
            .WithArguments(controls, settings.Rigidbody, settings.MoveSpeed);
    }

    [Serializable]
    public class Settings
    {
        public Rigidbody2D Rigidbody;
        public SpriteRenderer SpriteRenderer;

        public float MoveSpeed;
    }
}