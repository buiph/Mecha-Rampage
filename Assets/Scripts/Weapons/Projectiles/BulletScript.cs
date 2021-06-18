using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] public GameObject explosion;
    [SerializeField] public AudioSource myAudio;
    [SerializeField] public AudioClip explosionBlast;

    private void OnCollisionEnter(Collision collision)
    {
        //Play the explosion prefab
        Instantiate(explosion, transform.position, transform.rotation);

        //Play audio clip
        myAudio.clip = explosionBlast;
        AudioSource.PlayClipAtPoint(explosionBlast, transform.position, 1f);

        if (collision.gameObject.tag == "Damageable")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(10.0f);
            }
            //Debug.Log("hit");
        }
        this.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        StartCoroutine(Deactivate(5f));
    }

    /// <summary>
    /// Deactives this projectile after a period of time
    /// </summary>
    /// <param name="delay"></param>
    /// <returns></returns>
    IEnumerator Deactivate(float delay)
    {
        yield return new WaitForSeconds(delay);
        this.gameObject.SetActive(false);
    }
}
