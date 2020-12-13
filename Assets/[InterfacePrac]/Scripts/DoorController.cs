using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isDoorOpened = false;
    private Animator anim;
    public Animator Anim { get { return (anim == null) ? anim = GetComponent<Animator>() : anim; } }
    private void OnEnable()
    {
        EventManager.OnDoorInteraction.AddListener(InteractWithDoor);
    }
    private void OnDisable()
    {
        EventManager.OnDoorInteraction.RemoveListener(InteractWithDoor);
    }

    public void InteractWithDoor()
    {
        if (!isDoorOpened)
        {
            Anim.SetTrigger("Open");
            isDoorOpened = true;
        }
        else if (isDoorOpened)
        {
            Anim.SetTrigger("Close");
            isDoorOpened = false;
        }
    }
}
