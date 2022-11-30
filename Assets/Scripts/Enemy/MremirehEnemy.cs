using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FightingGame.Enemy
{
    public class MremirehEnemy : EnemyStateManager
    {
        public float Dis; 
        public override void DamageEffect()
        {
          
        }

        public override void HowDamage()
        {

        }

        private void Awake()
        {
            base.Awake();
        }

        void Start()
        {
         
        }

        void Update()
        {
            Dis = Vector3.Distance(transform.position, GameManager.instance.player.transform.position);
            base.Update();
        }
    }
}