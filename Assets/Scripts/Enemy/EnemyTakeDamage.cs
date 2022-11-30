using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame.Enemy
{

    public class EnemyTakeDamage : TakeDamage
    {
        public override void Damage(DamagerScriptableObject data)
        {
            base.Damage(data);
            
        }
    }
}