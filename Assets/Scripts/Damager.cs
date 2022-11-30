using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame
{

    public class Damager : MonoBehaviour
    {
        public bool canDamage = false;  
        [SerializeField] DamagerScriptableObject damageDate;
        private void OnTriggerEnter(Collider collision)
        {
            print(collision.name);
            if (canDamage && collision.CompareTag(damageDate.target.ToString()))
            {
                print(collision.name + " +++");

                collision.GetComponent<TakeDamage>().Damage(damageDate);

            }
        }
    }
}
