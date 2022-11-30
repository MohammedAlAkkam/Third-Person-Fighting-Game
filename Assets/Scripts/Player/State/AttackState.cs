using UnityEngine;

namespace FightingGame.Player
{
    public class AttackState : BaseState
    {
        [SerializeField] private Damager damager;
        int AttackIndex = 0;
        bool nextAttack = false;
        bool canDamage = false;

        const int MaxAttackCount = 1;

        public override void Enter()
        {
            AttackIndex = 1;
            Manager.animator.SetTrigger(Utilities.hashedAttackIndex);
        }

        public override void UpdateState()
        {
            if (InputHandler.instance.isAttack)
                nextAttack = true;
        }

        public void CanDamaga()
        {
            canDamage = !canDamage;
        }

        public void FinishAttack()
        {
            if (nextAttack && AttackIndex < MaxAttackCount)
            {
                AttackIndex++;
                Manager.animator.SetTrigger(Utilities.hashedAttackIndex);
            }
            else
            {
                Manager.ActivateDefaultState();
            }
        }

        public override bool CanSwitch()
        {
            return Manager.externalInfluences.IsGrounded && Manager.current != this;
        }

        public void CanDamageChange(int state)
        {
            damager.canDamage = state == 0 ? false : true;
        }
    }
}