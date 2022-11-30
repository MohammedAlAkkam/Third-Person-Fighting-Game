using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerUIManager : MonoBehaviour
{
    public static PlayerUIManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    [SerializeField] TextMeshProUGUI m_TextMeshPro;

    public void DamageEffectUI(float health)
    {
        m_TextMeshPro.text = health.ToString();
    }
}
