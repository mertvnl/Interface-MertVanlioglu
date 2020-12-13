using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthWaste : WasteableBase
{
    public override void Waste()
    {
        if (HealthManager.Instance.health>0)
        {
            EventManager.OnWasteHealth.Invoke();
        }
        else
        {
            Debug.Log("You don't have enough health points to waste!!!");
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            
            Waste();
        }
    }
}
