using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    public float _maxHealth, _currentHealth;
    [SerializeField]
    GameObject _destructible;

    public event Action<GameObject> OnInactive;

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            Death();
        }
    }

    /// <summary>
    /// Handles the logic when this object is destroyed
    /// </summary>
    void Death()
    {
        OnInactive?.Invoke(this.gameObject);

        gameObject.SetActive(false);

        if (_destructible != null)
        {
            GameObject go = Instantiate(_destructible, transform.position, transform.rotation);
            Destroy(go, 4f);
        }        
    }
}