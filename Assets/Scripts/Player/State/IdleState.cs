using UnityEngine;
namespace FightingGame.Player
{
    public class IdleState : BaseState
    {
        [SerializeField] private MoveState moveState;
        AttackState attackState;

        public override bool CanSwitch()
        {
            return Manager.externalInfluences.IsGrounded;//&& Manager.animator.GetCurrentAnimatorStateInfo(0).IsTag("Move");    
        }

        public override void Enter() { }

        public override void UpdateState()
        {
            Manager.animator.SetFloat(Utilities.hashedSpeedIndex, InputHandler.instance.dir.magnitude);//,.1f,Time.deltaTime);

            if (InputHandler.instance.dir.magnitude > .3f)
            {
                Manager.SwitchState(moveState);
            }
        }
    }
}
