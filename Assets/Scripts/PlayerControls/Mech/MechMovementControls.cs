using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechMovementControls : MonoBehaviour
{
    float xValAdj, yValAdj, movementSpeed, rotationSpeed;

    PlayerInputAction inputAction;
    Vector2 movementInput;

    [SerializeField] public AudioSource myAudio;
    [SerializeField] public AudioClip movementSound;
    internal bool locked;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.MechControls.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
    }

    void Start()
    {
        movementSpeed = 13f;
        rotationSpeed = 80f;
        locked = false;
    }

    void Update()
    {
        //Get input
        if (!locked)
        {
            xValAdj = movementInput.x;
            yValAdj = movementInput.y;
        }
        else
        {
            xValAdj = 0;
            yValAdj = 0;
        }

        // Play audio while there is movement input
        if ((xValAdj != 0 || yValAdj != 0) && !myAudio.isPlaying)
        {
            myAudio.clip = movementSound;
            myAudio.Play();
        }
        else if (xValAdj == 0 && yValAdj == 0)
        {
            myAudio.Stop();
        }

        // Change your Translate and Rotate
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * yValAdj, Space.Self);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * xValAdj, Space.Self);
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
