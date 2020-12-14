using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum WhatToInteract
    {
        Nothing,
        Apple,
        Ammo,
        Door
    }

    public WhatToInteract currentInteraction;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Rigidbody.velocity.y / 10, Input.GetAxis("Vertical"));
        Rigidbody.velocity = input * 500 * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        DoorController door = other.GetComponentInChildren<DoorController>();
        if (door != null)
        {
            currentInteraction = WhatToInteract.Door;
            FindObjectOfType<WhatToInteractText>().interactWith = "Door";
            FindObjectOfType<WhatToInteractText>().UpdateText();
        }


        AppleController apple = other.GetComponentInChildren<AppleController>();
        if (apple != null)
        {
            currentInteraction = WhatToInteract.Apple;
            FindObjectOfType<WhatToInteractText>().interactWith = "Apple";
            FindObjectOfType<WhatToInteractText>().UpdateText();
        }

        AmmoController ammo = other.GetComponentInChildren<AmmoController>();
        if (ammo != null)
        {
            currentInteraction = WhatToInteract.Ammo;
            FindObjectOfType<WhatToInteractText>().interactWith = "Ammo";
            FindObjectOfType<WhatToInteractText>().UpdateText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        currentInteraction = WhatToInteract.Nothing;
        FindObjectOfType<WhatToInteractText>().interactWith = "Nothing";
        FindObjectOfType<WhatToInteractText>().UpdateText();
    }



}
