
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FightingGame
{

    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DamagerScriptableObject", order = 1)]
    public class DamagerScriptableObject : ScriptableObject
    {
        public string name;
        public int animationId;
        public int damageAmount;
        public TargetToDamage target;
    }
}