using UnityEngine;
namespace FightingGame.Player
{
    public class JumpState : BaseState
    {
        public float jumpPower = 12;

        public override bool CanSwitch()
        {
            return (Manager.externalInfluences.IsGrounded && !Manager.animator.GetCurrentAnimatorStateInfo(0).IsTag("NotGrounded"));
        }

        public override void Enter()
        {
            Manager.animator.SetTrigger(Utilities.hashedJumpIndex);
            //stateManager.rb.velocity = Vector3.zero;
            Manager.rb.velocity = Manager.transform.forward * 4;
            Manager.rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        public override void UpdateState() { }
    }
}