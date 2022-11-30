using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame.Enemy
{
    public class Attack : BaseState
    {
        public MoveState moveState;
        [SerializeField] private Damager damager;
        

        private void Awake()
        {

            base.Awake();

        }
        public override bool CanSwitch()
        {
            return true;//Vector3.Distance(GameManager.instance.player.transform.position, transform.position) > Utilities.DistanceToAttack;
        }

        public override void Enter()
        {

            Manager.animator.SetTrigger("Attack");
        }
        private void Update()
        {
            
        }
        public override void UpdateState()
        {
            if (Vector3.Distance(GameManager.instance.player.transform.position, transform.position) >= Utilities.DistanceToAttack +.2f)
            {
                damager.canDamage = false;
                Manager.SwitchState(moveState);
            }
        }
        public void CanDamageChange(int state)
        {
           damager.canDamage = state == 0?false : true;
        }

    }
}
