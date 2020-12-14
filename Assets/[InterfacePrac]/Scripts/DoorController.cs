using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, I_Interactable
{
    private bool isDoorOpened = false;
    private Animator anim;
    public Animator Anim { get { return (anim == null) ? anim = GetComponent<Animator>() : anim; } }
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

    public void Waste()
    {
        throw new System.NotImplementedException();
    }
}
