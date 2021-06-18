using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactables : MonoBehaviour
{
    GameObject player;
    bool isEquipped; // Whether is object is currently equipped by the player

    void Start()
    {
        isEquipped = false;
    }

    void Update()
    {
        if (this.transform.parent == null)
        {
            this.gameObject.GetComponent<Collider>().isTrigger = true;
            isEquipped = false;
        }
        else
        {
            this.gameObject.GetComponent<Collider>().isTrigger = false;
            isEquipped = true;
        }
    }

    /// <summary>
    /// Handles the logic when this object is interacted with
    /// </summary>
    internal void Interacted()
    {
        player.GetComponent<InteractionController>().SetInteractText("", false);
        player.GetComponent<WeaponManager>().EnterSlotSelect();
    }

    void OnTriggerEnter(Collider collidedWith)
    {
        if (collidedWith.gameObject.tag == "Player" && !isEquipped)
        {
            player = collidedWith.gameObject;
            player.GetComponent<InteractionController>().interactObject = this.gameObject;
            player.GetComponent<InteractionController>().SetInteractText("[F] Pickup", true);
        }
    }

    void OnTriggerExit(Collider collidedWith)
    {
        if (collidedWith.gameObject.tag == "Player")
        {
            player.GetComponent<InteractionController>().interactObject = null;
            player.GetComponent<InteractionController>().SetInteractText("", false);
            player = null;
        }
    }
}
