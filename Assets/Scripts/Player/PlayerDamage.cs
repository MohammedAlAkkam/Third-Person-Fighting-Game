using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDamage : MonoBehaviour
{
    private void Awake()
    {
        DamageHandler = new UnityEvent<int>();
        DamageHandler.AddListener(Damage);
    }
    public UnityEvent<int>  DamageHandler;
    public void Damage(int amount)
    {
      //  health -= amount;
    }
    private void Update()
    {
        DamageHandler.Invoke(1);
    }
}
