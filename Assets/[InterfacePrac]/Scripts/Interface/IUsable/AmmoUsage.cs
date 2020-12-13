using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoUsage : UsableBase
{

    public override void Use()
    {
        base.Use();
        AmmoManager.Instance.ammo++;
        EventManager.OnAmmoInteraction.Invoke();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.interactWith == "Ammo")
        {
            Use();
        }
    }
}