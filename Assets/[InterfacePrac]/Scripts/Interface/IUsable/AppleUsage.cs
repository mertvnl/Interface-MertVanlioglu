using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleUsage : UsableBase
{
    public override void Use()
    {
        base.Use();
        HealthManager.Instance.health++;
        EventManager.OnAppleInteraction.Invoke();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GameManager.Instance.interactWith == "Apple")
        {
            Use();
        }
    }
}
