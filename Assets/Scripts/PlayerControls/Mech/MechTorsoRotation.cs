using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechTorsoRotation : MonoBehaviour
{
    float rHori, rotationSpeed;
    internal bool locked;
    PlayerInputAction inputAction;
    Vector2 rotationInput;
    Vector3 angles;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.MechControls.Look.performed += ctx => rotationInput = ctx.ReadValue<Vector2>();
    }

    void Start()
    {
        rotationSpeed = 6f;
        locked = false;
    }

    void Update()
    {
        //Get input
        if (!locked)
        {
            rHori = rotationInput.x;
        }
        else
        {
            rHori = 0;
        }

        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * rHori, Space.World);
        angles = transform.localRotation.eulerAngles;

        //Clamp rotation
        if (angles.y > 90 && angles.y < 180)
        {
            transform.localRotation = Quaternion.Euler(angles.x, 90.0f,
            0);
        }
        if (angles.y < 270 && angles.y > 180)
        {
            transform.localRotation = Quaternion.Euler(angles.x, 270.0f,
            0);
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
