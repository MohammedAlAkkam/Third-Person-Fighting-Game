using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame.Enemy
{
    public abstract class BaseState : MonoBehaviour
    {
        public EnemyStateManager Manager { get; private set; }
       
        protected virtual void Awake()
        {
            Manager = GetComponent<EnemyStateManager>();
        } 

        public abstract void Enter();
        public abstract void UpdateState();
        public abstract bool CanSwitch();
    }

}