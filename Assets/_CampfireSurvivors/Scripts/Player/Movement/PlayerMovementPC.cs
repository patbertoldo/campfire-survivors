using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace CampfireSurvivors.Player.Movement
{
    public class PlayerMovementPC : IPlayerMovement
    {
        private Keyboard keyboard;
        private Rigidbody2D rigidbody2D;

        private float moveSpeed;

        PlayerMovementPC(PlayerMovementSettings settings)
        {
            rigidbody2D = settings.Rigidbody2D;

            moveSpeed = settings.moveSpeed;
        }

        void IInitializable.Initialize()
        {
            keyboard = Keyboard.current;
        }

        void IFixedTickable.FixedTick()
        {
            Vector2 movement = Vector2.zero;

            if (keyboard.wKey.isPressed)
            {
                movement += Vector2.up;
            }
            if (keyboard.sKey.isPressed)
            {
                movement += Vector2.down;
            }
            if (keyboard.aKey.isPressed)
            {
                movement += Vector2.left;
            }
            if (keyboard.dKey.isPressed)
            {
                movement += Vector2.right;
            }

            rigidbody2D.position += movement.normalized * moveSpeed * Time.fixedDeltaTime;
        }
    }
}
