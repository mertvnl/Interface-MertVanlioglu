using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUsage : UsableBase
{
    public override void Use()
    {
        base.Use();
        EventManager.OnDoorInteraction.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.interactWith == "Door")
        {
            Use();
        }
    }
}