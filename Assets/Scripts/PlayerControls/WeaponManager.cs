using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] public List<Transform> weaponSlotPos;
    internal GameObject[] weaponSlots = new GameObject[4];
    [SerializeField] public Transform dropPos;

    // UI elements
    [SerializeField] public List<RawImage> slotUI;
    [SerializeField] public GameObject slotPannel;

    GameObject collidedWeapon;
    internal float scrollInput;
    internal int activeSlotIndex;
    internal bool _held; //Variable for whether the fire button is held down

    PlayerInputAction inputAction;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.MechControls.Shoot.performed += _ => _held = !_held;
        inputAction.MechControls.ChangeActiveWeapon.performed += ctx => scrollInput = ctx.ReadValue<float>();
        inputAction.MechControls.Unequip.performed += _ => Unequip(activeSlotIndex);
    }

    void Start()
    {
        slotPannel.SetActive(false);
        activeSlotIndex = 0;

        _held = false;
    }

    void Update()
    {
        if (Time.timeScale != 0)
        {
            // Handles scolling through the weapon slots
            if (scrollInput > 0)
            {
                activeSlotIndex++;
            }
            else if (scrollInput < 0)
            {
                activeSlotIndex--;
            }

            if (activeSlotIndex > 3)
            {
                activeSlotIndex = 0;
            }
            if (activeSlotIndex < 0)
            {
                activeSlotIndex = 3;
            }

            // Changes the color of the active slot
            for (int i = 0; i < slotUI.Count; i++)
            {
                if (i == activeSlotIndex)
                {
                    slotUI[i].color = new Color(1f, 0.45f, 0f);
                }
                else
                {
                    slotUI[i].color = Color.white;
                }
            }
        }

        UpdateActiveWeapon();

        if (_held && Time.timeScale != 0 && weaponSlots[activeSlotIndex] is GameObject)
        {
            weaponSlots[activeSlotIndex].GetComponent<Weapon>().FireWeapon();
        }
    }

    /// <summary>
    /// Equip a weapon to slot index
    /// </summary>
    /// <param name="slotIndex"></param>
    public void Equip(int slotIndex)
    {
        // Unequip whatever weapon might be there
        Unequip(slotIndex);

        // Assign the equippe weapon to the slot selected
        collidedWeapon.transform.position = weaponSlotPos[slotIndex].position;
        collidedWeapon.transform.rotation = weaponSlotPos[slotIndex].rotation;
        collidedWeapon.transform.parent = weaponSlotPos[slotIndex];

        weaponSlots[slotIndex] = collidedWeapon;

        ExitSlotSelect();
    }

    /// <summary>
    /// Unequip the weapon at slot index
    /// </summary>
    /// <param name="slotIndex"></param>
    internal void Unequip(int slotIndex)
    {
        // If there is a weapon, drop it and remove all references
        if (weaponSlots[slotIndex] is GameObject)
        {
            Transform currWeapon = weaponSlots[slotIndex].transform;
            currWeapon.position = dropPos.position;
            currWeapon.rotation = dropPos.rotation;
            currWeapon.parent = null;

            weaponSlots[slotIndex] = null;
        }
    }

    /// <summary>
    /// Update weapon slot panel to reflect the status of the current active weapon
    /// </summary>
    void UpdateActiveWeapon()
    {
        for (int i = 0; i < weaponSlotPos.Count; i++)
        {
            if (weaponSlots[i] is GameObject)
            {
                slotUI[i].GetComponentInChildren<Text>().text = weaponSlots[i].name + 
                "\n" + 
                weaponSlots[i].GetComponent<Weapon>()._bulletsInClip + 
                "/" + 
                weaponSlots[i].GetComponent<Weapon>()._clipSize;
            }
            else
            {
                slotUI[i].GetComponentInChildren<Text>().text = "Empty\n0/0";
            }
        }
    }

    /// <summary>
    /// Enter weapon slot select mode
    /// </summary>
    public void EnterSlotSelect()
    {
        slotPannel.SetActive(true);
        Time.timeScale = 0;
    }

    /// <summary>
    /// Exit weapon slot select mode
    /// </summary>
    public void ExitSlotSelect()
    {
        slotPannel.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider collidedWith)
    {
        if (collidedWith.transform.tag == "Weapon")
        {
            collidedWeapon = collidedWith.gameObject;
        }
    }

    private void OnTriggerExit(Collider collidedWith)
    {
        if (collidedWith.transform.tag == "Weapon")
        {
            collidedWeapon = null;
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
