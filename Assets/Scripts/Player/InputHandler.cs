using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

namespace FightingGame.Player
{
    public class InputHandler : MonoBehaviour
    {
        [Serializable]
        public class InputAction
        {
            public KeyCode[] keys;
            public UnityEvent state;

            public bool HasActive()
            {
                for (int i = 0; i < keys.Length; i++)
                    if (Input.GetKeyDown(keys[i]))
                        return true;
                return false;
            }
        }

        public InputAction[] actions;

        public static InputHandler instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);
                instance.dir = new Vector3();
            }

            else
                Destroy(instance);
        }
        public Vector3 dir;
        public bool isJump;
        public bool isAttack;
        public void ReadInput()
        {
            for (int i = 0; i < actions.Length; i++)
            {
                if (actions[i].HasActive())
                {
                    actions[i].state.Invoke();
                }
            }
            dir.x = Input.GetAxis("Horizontal");
            dir.z = Input.GetAxis("Vertical");
            isJump = Input.GetKey(KeyCode.Space);
            isAttack = Input.GetKeyDown(KeyCode.Mouse0);

        }

        public Vector3 GetNormalizeDir()
        {
            return dir.normalized;
        }
    }
}