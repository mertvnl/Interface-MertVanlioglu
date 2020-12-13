using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoWaste : WasteableBase
{
    public override void Waste()
    {
        if (AmmoManager.Instance.ammo > 0)
        {
            EventManager.OnWasteAmmo.Invoke();
        }
        else
        {
            Debug.Log("You don't have enough ammo to waste!!!");
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            Waste();
        }
    }
}
