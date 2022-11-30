using FightingGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame
{
    public class TakeDamage : MonoBehaviour
    {
        [Range(0, 1)] public float damageAbility;
        public float health;

        public virtual void Damage(DamagerScriptableObject data)
        {
            print("Damade");
            health -= data.damageAmount * damageAbility;
            if(health < 0)
                Destroy(gameObject);
        }

    }
}