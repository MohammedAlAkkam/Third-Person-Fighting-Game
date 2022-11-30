using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame.Enemy {
    public class MoveState : BaseState
    {
        [SerializeField] private IdleState _idleState;
        [SerializeField] private Attack _attackState;
        private Vector3 Dir;
        private void Awake()
        {
            base.Awake();
        }
        public override bool CanSwitch()
        {
            return Vector3.Distance(GameManager.instance.player.transform.position, transform.position) < 4;
        }

        public override void Enter()
        {
            Manager.animator.SetTrigger("Move");

        }
            
        public override void UpdateState()
        {
            Dir = (GameManager.instance.player.transform.position - transform.position);
            Quaternion rotat = Quaternion.LookRotation(Dir);
            Vector3 rotatDir = rotat.eulerAngles;
            transform.rotation = Quaternion.Euler(0, rotatDir.y, 0);
            Manager.characterController.Move(Dir.normalized  * Time.deltaTime * .8f);
           
            if (Vector3.Distance(GameManager.instance.player.transform.position, transform.position) > Utilities.DistanceToMove)
            {
                Manager.SwitchState(_idleState);
            }
             if (Vector3.Distance(GameManager.instance.player.transform.position, transform.position) < Utilities.DistanceToAttack)
            {
                Manager.SwitchState(_attackState);
            }
        }
        
    }
}