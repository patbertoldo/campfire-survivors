using CampfireSurvivors.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace CampfireSurvivors
{
    public class PlayerMovement : IInitializable, IFixedTickable
    {
        readonly private PlayerInputControls controls;
        private readonly Rigidbody2D rigidbody2D;
        private readonly float moveSpeed;

        public PlayerMovement(PlayerInputControls controls, Rigidbody2D rigidbody2D, float moveSpeed)
        {
            this.controls = controls;
            this.rigidbody2D = rigidbody2D;
            this.moveSpeed = moveSpeed;
        }

        void IInitializable.Initialize()
        {
            SetActiveGameplayActions(true);
        }

        void IFixedTickable.FixedTick()
        {
            Vector2 inputVector = controls.Gameplay.Move.ReadValue<Vector2>();

            rigidbody2D.position += inputVector.normalized * moveSpeed * Time.fixedDeltaTime;
        }

        public void SetActiveGameplayActions(bool active)
        {
            if (active)
            {
                controls.Gameplay.Enable();
            }
            else
            {
                controls.Gameplay.Disable();
            }
        }
    }
}
