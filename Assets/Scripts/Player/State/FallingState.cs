using UnityEngine;
namespace FightingGame.Player
{
    public class FallingState : BaseState
    {
        public Vector3 boxSize = Vector3.one * .1f;
        public float maxDistance;

        public override bool CanSwitch()
        {
            return Manager.current != this;
        }

        public override void Enter()
        {
            Debug.Log("Enter to falling");
            Manager.animator.SetFloat(Utilities.hashedY_velocityIndex, Manager.rb.velocity.y);
            Manager.animator.ResetTrigger(Utilities.hashedJumpIndex);
            //stateManager.animator.SetBool(Utilities.hashedGroundedIndex, false);
        }

        public override void UpdateState()
        {
            if (Manager.externalInfluences.IsGrounded)
            {
                Manager.animator.SetBool(Utilities.hashedGroundedIndex, true);

                Manager.ActivateDefaultState();
                Manager.animator.SetFloat(Utilities.hashedSpeedIndex, .5f);

            }
        }
    }
}