using System;
using UnityEngine;
namespace FightingGame.Player
{
    [RequireComponent(typeof(StateManager))]
    public class ExternalInfluences : MonoBehaviour
    {

        public static event Action OnTackDamage;

        public StateManager stateManager;
        public FallingState fallingState;
        public LayerMask groundLayer;

        public bool IsGrounded { get; private set; }
        public bool grounded;

        private readonly Collider[] colliders = new Collider[10];

        void Start()
        {

            stateManager = GetComponent<StateManager>();
        }

        void Update()
        {
            grounded = IsGrounded = Physics.OverlapSphereNonAlloc(stateManager.transform.position, .1f, colliders, groundLayer) != 0;
            stateManager.animator.SetBool(Utilities.hashedGroundedIndex, IsGrounded);
            if (stateManager.rb.velocity.y < -1f)
            {
                stateManager.SwitchState(fallingState);
            }
        }
    }
}
