using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame.Player
{
    public class PlayerTakeDamage : TakeDamage
    {
        private StateManager stateManager;
        private void Start()
        {
        
        }
        public override void Damage(DamagerScriptableObject data)
        {
        base.Damage(data);
            PlayerUIManager.Instance.DamageEffectUI(health);
        }

        private void Awake()
        {
            stateManager = GetComponent<StateManager>();
        }
    }
}
