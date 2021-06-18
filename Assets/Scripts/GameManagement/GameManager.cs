using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> buildings;
    [SerializeField] List<GameObject> ammoBoxes;

    void Start()
    {
        foreach (GameObject building in buildings)
        {
            building.GetComponent<Health>().OnInactive += Reactivate;
        }

        foreach (GameObject ammo in ammoBoxes)
        {
            ammo.GetComponent<Consumables>().OnInactive += Reactivate;
        }
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    /// <summary>
    /// Acts as middle man between the event and coroutine
    /// </summary>
    /// <param name="caller"></param>
    internal void Reactivate(GameObject caller)
    {
        StartCoroutine(Respawn(caller));
    }

    /// <summary>
    /// Reactivate object in 5 seconds
    /// </summary>
    /// <param name="caller"></param>
    /// <returns></returns>
    IEnumerator Respawn(GameObject caller)
    {
        yield return new WaitForSeconds(5);

        caller.SetActive(true);
    }
}
