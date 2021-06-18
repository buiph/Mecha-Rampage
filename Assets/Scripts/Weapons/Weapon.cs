using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected float _fireRate, _timeStamp;
    [SerializeField] public int _clipSize;
    [SerializeField] public int _bulletsInClip;
    
    public abstract void FireWeapon();
}
