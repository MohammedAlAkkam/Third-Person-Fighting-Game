using UnityEngine;
namespace FightingGame.Player
{
    public abstract class BaseState : MonoBehaviour
    {
        public StateManager Manager { get; private set; }

        protected virtual void Awake()
        {
            Manager = GetComponent<StateManager>();
        }

        public abstract void Enter();
        public abstract void UpdateState();
        public abstract bool CanSwitch();
    }

}