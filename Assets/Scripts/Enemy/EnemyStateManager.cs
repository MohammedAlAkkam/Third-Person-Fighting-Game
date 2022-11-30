using UnityEngine;
namespace FightingGame.Enemy
{
    public abstract class EnemyStateManager : MonoBehaviour
    {
       
        [SerializeField] protected int damageAmount;

        protected BaseState current;
        public CharacterController characterController;
        protected IdleState idleState;
        
        public Animator animator;
        

        public abstract void DamageEffect();
        public abstract void HowDamage();
        public string stateName;
        protected void Awake()
        {
            animator = GetComponent<Animator>();
            characterController = GetComponent<CharacterController>();
            idleState = GetComponent<IdleState>();
            
            print("Start Enemy");
            SwitchState(idleState); 
        }

        protected void Update()
        {
            stateName = current.ToString();
            current.UpdateState();
        }

        public void SwitchState(BaseState newState)
        {
            print(newState.ToString() + " ====");
            current = newState;
            newState.Enter();
        }
        private void OnDisable()
        {
            enabled = true;
        }
    }
}