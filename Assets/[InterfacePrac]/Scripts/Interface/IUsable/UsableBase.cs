using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UsableBase : MonoBehaviour, IUsable
{
    public virtual void Use()
    {
        Debug.Log("Interacting with : " + GameManager.Instance.interactWith);
    }
}
