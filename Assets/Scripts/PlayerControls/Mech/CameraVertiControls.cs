using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVertiControls : MonoBehaviour
{
    float rVerti, rotationSpeed;
    internal bool locked;
    bool playerOnRight;
    PlayerInputAction inputAction;
    Vector2 rotationInput;
    Vector3 angles;

    [SerializeField] public GameObject armBase;

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
        if (!locked)
        {
            rVerti = rotationInput.y;
        }
        else
        {
            rVerti = 0;
        }

        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * rVerti * -1, Space.Self);
        armBase.transform.rotation = this.transform.rotation;
        angles = transform.rotation.eulerAngles;

        //Clamp rotation
        if (angles.x > 45 && angles.x < 90)
        {
            transform.rotation = Quaternion.Euler(45.0f, angles.y, 0);
            armBase.transform.rotation = Quaternion.Euler(45.0f, angles.y, 0);
        }
        if (angles.x < 315 && angles.x > 270)
        {
            transform.rotation = Quaternion.Euler(315.0f, angles.y, 0);
            armBase.transform.rotation = Quaternion.Euler(315.0f, angles.y, 0);
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
