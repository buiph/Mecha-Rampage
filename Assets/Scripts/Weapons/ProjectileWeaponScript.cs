using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponScript : Weapon
{
    [SerializeField] public GameObject projectile, nozzle;
    [SerializeField] public GameObject nozzleFlash;
    [SerializeField] public AudioSource myAudio;
    [SerializeField] public AudioClip gunBlast;
    [SerializeField] public AudioClip gunEmpty;
    [SerializeField] public float velocity;
    GameObject[] bulletPool;

    int bulletIndex;

    void Start()
    {
        _fireRate = 0.5f;
        _timeStamp = -0.5f;

        bulletPool = new GameObject[_clipSize];
        for (int i = 0; i < bulletPool.Length; i++)
        {
            bulletPool[i] = Instantiate(projectile, Vector3.zero, Quaternion.identity);
            //Ignore the gun collider
            Physics.IgnoreCollision(this.gameObject.GetComponent<Collider>(), bulletPool[i].GetComponentInChildren<Collider>());
        
            bulletPool[i].SetActive(false);
        }

        bulletIndex = 0;
        _bulletsInClip = _clipSize;
    }

    /// <summary>
    /// Fires this weapon
    /// </summary>
    public override void FireWeapon()
    {
        if (Time.time > _timeStamp + _fireRate)
        {
            _timeStamp = Time.time;

            if (_bulletsInClip > 0)
            {
                //Play the explosion prefab
                GameObject flash = Instantiate(nozzleFlash, nozzle.transform.position, nozzle.transform.rotation);
                flash.transform.parent = this.transform;
                Destroy(flash, 0.2f);

                //Assign audio clip
                myAudio.clip = gunBlast;

                //Set the fired bullet to Active
                bulletPool[bulletIndex].SetActive(true);
                bulletPool[bulletIndex].transform.position = nozzle.transform.position;
                bulletPool[bulletIndex].GetComponent<Rigidbody>().velocity = nozzle.transform.forward * velocity;

                //Cycles through the object pool
                bulletIndex++;
                if (bulletIndex >= bulletPool.Length)
                {
                    bulletIndex = 0;
                }

                _bulletsInClip--;
            }
            else
            {
                //Assign audio clip
                myAudio.clip = gunEmpty;
            }

            //Play audio clip
            myAudio.Play();
        }
    }
}
