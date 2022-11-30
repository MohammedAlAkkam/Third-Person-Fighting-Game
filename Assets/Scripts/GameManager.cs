using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FightingGame.Player.StateManager player;
    public static GameManager instance;
    private void Awake()
    {
     if(instance == null)
            instance = this;    
     else Destroy(this);
    }
}
