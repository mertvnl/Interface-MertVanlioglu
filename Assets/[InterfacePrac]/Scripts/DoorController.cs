using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, IUsable
{
    private bool isDoorOpened = false;
    private Animator anim;
    public Animator Anim { get { return (anim == null) ? anim = GetComponent<Animator>() : anim; } }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && FindObjectOfType<PlayerController>().currentInteraction == PlayerController.WhatToInteract.Door)
        {
            Use();
        }
    }

    public void Use()
    {
        if (!isDoorOpened)
        {
            Anim.SetTrigger("Open");
            isDoorOpened = true;
            Debug.Log("You opened the door");
        }
        else if (isDoorOpened)
        {
            Anim.SetTrigger("Close");
            isDoorOpened = false;
            Debug.Log("You closed the door");
        }
    }

}
