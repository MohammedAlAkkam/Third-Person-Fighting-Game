using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame.Enemy
{
    public class IdleState : BaseState
    {
        public MoveState moveState;
        private void Awake()
        {

            base.Awake();
           
        }
        public override bool CanSwitch()
        {
            return Vector3.Distance(GameManager.instance.player.transform.position, transform.position) > Utilities.DistanceToMove;
        }

        public override void Enter()
        {
            print("Enter To State");
            Manager.animator.SetTrigger("Idle");
        }

        public override void UpdateState()
        {
            if (Vector3.Distance(GameManager.instance.player.transform.position, transform.position) < Utilities.DistanceToMove)
            {
                Manager.SwitchState(moveState);
            }
        }
    }
}