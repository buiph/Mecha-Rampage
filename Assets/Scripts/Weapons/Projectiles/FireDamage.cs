using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public ParticleSystem fire;
    public List<ParticleCollisionEvent> collisionEvents;

    float timeStamp;
    float damageRate;

    void Start()
    {
        fire = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();

        timeStamp = -0.5f;
        damageRate = 0.2f;
    }

    void OnParticleCollision(GameObject other)
    {
        int numCollisionEvents = fire.GetCollisionEvents(other, collisionEvents);
        int i = 0;

        //Damages target at a certain rate over time
        while (i < numCollisionEvents)
        {
            if (other.gameObject.tag == "Damageable" && Time.time >= timeStamp + damageRate)
            {
                timeStamp = Time.time;

                Health health = other.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(3.0f);
                }
            }
            i++;
        }
    }
}
