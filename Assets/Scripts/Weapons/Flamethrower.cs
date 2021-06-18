using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : Weapon
{
    [SerializeField] public GameObject effect, nozzle;
    [SerializeField] public AudioSource myAudio;
    [SerializeField] public AudioClip fireBurning;
    [SerializeField] public AudioClip outOfFuel;

    GameObject fire;

    PlayerInputAction inputAction;
    bool held, isEmitting;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.MechControls.Shoot.performed += _ => held = !held;
    }

    void Start()
    {
        _fireRate = 10f;
        _timeStamp = -0.5f;
        held = false;
        isEmitting = false;

        _bulletsInClip = _clipSize;
    }

    void Update()
    {
        if (held && _bulletsInClip > 0 && isEmitting)
        {
            _bulletsInClip--;
            if (_bulletsInClip < 0)
            {
                _bulletsInClip = 0;
            }

            if (!myAudio.isPlaying)
            {
                myAudio.clip = fireBurning;
                myAudio.Play();
            }
        }
        else if ((!held || _bulletsInClip <= 0) && isEmitting)
        {
            fire.GetComponent<ParticleSystem>().Stop(true);
            isEmitting = false;

            myAudio.clip = outOfFuel;
            if (!myAudio.isPlaying)
            {
                myAudio.Play();
            }
        }

        if (!held && myAudio.isPlaying)
        {
            myAudio.Stop();
        }
    }

    /// <summary>
    /// Fires this weapon
    /// </summary>
    public override void FireWeapon()
    {
        if (!isEmitting)
        {
            fire = Instantiate(effect, nozzle.transform.position, nozzle.transform.rotation);
            fire.transform.parent = this.transform;
            isEmitting = true;
        }
    }

    //Enable and disable the input action
    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }
}
