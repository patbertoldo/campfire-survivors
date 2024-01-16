using System;
using UnityEngine;
using Zenject;

namespace CampfireSurvivors.Player.Movement
{
    public interface IPlayerMovement : IInitializable, IFixedTickable
    {
    }

    [Serializable]
    public class PlayerMovementSettings
    {
        public Rigidbody2D Rigidbody2D;
        public float moveSpeed = 1f;
    }
}
