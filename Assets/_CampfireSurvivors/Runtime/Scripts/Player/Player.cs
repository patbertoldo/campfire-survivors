using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CampfireSurvivors.Player
{
    public class Player
    {
        private readonly Rigidbody rigidBody2D;
        private readonly SpriteRenderer spriteRenderer;
        private readonly PlayerInputControls controls;

        public Player(
            PlayerInputControls controls,
            Rigidbody rigidBody2D,
            SpriteRenderer spriteRenderer)
        {
            this.controls = controls;
            this.rigidBody2D = rigidBody2D;
            this.spriteRenderer = spriteRenderer;
        }
    }
}
