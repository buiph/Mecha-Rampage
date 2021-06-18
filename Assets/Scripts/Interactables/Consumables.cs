using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumables : MonoBehaviour
{
    public event Action<GameObject> OnInactive;

    void OnTriggerEnter(Collider collidedWith)
    {
        if (collidedWith.gameObject.tag == "Player")
        {
            foreach (var slot in collidedWith.gameObject.GetComponent<WeaponManager>().weaponSlots)
            {
                if (slot is GameObject)
                {
                    slot.GetComponent<Weapon>()._bulletsInClip = slot.GetComponent<Weapon>()._clipSize;
                }
            }

            OnInactive?.Invoke(this.gameObject);

            this.gameObject.SetActive(false);
        }
    }
}
