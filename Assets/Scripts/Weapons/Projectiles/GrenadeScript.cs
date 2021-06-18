using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScript : MonoBehaviour
{
    [SerializeField] public float blastRadius;
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

        Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, blastRadius);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.tag == "Damageable")
            {
                Health health = hitCollider.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(8.0f);
                }
            }
        }
        this.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        StartCoroutine(Deactivate(5f));
    }

    /// <summary>
    /// Deactivates the xplosion after a delay
    /// </summary>
    /// <param name="delay"></param>
    /// <returns></returns>
    IEnumerator Deactivate(float delay)
    {
        yield return new WaitForSeconds(delay);
        this.gameObject.SetActive(false);
    }
}
