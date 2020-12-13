using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WasteableBase : MonoBehaviour, IWasteable
{
    public abstract void Waste();
}
