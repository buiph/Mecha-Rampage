using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    [SerializeField] public Text interactText;
    [SerializeField] public GameObject interactObject;
    bool canInteract;

    PlayerInputAction inputAction;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.MechControls.Interact.performed += _ => Interact();
    }

    void Start()
    {
        interactText.gameObject.SetActive(false);

        canInteract = false;
    }

    /// <summary>
    /// Handles the logic when an interaction is triggered
    /// </summary>
    void Interact()
    {
        if (canInteract)
        {
            // Using send message because only 1 object should be interacted with at one time
            interactObject.GetComponent<Interactables>().Interacted();
        }
    }

    /// <summary>
    /// Set the text prompt for the interaction
    /// </summary>
    /// <param name="text"></param>
    /// <param name="interactable"></param>
    internal void SetInteractText(string text, bool interactable)
    {
        canInteract = interactable;

        if (text == "")
        {
            interactText.gameObject.SetActive(false);
        }
        else
        {
            interactText.gameObject.SetActive(true);
            interactText.text = text;
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
