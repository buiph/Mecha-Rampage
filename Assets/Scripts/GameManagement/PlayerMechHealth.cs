using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMechHealth : Health
{
    //NOTE
    //CURRENTLY NOT IN USE

    [SerializeField] public Text armorText;

    void Start()
    {
        
    }

    void Update()
    {
        armorText.text = _currentHealth + "/" + _maxHealth;
    }
}
