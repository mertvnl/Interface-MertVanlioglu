using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static UnityEvent OnDoorInteraction = new UnityEvent();
    public static UnityEvent OnAppleInteraction = new UnityEvent();
    public static UnityEvent OnAmmoInteraction = new UnityEvent();
    public static UnityEvent WhatToInteract = new UnityEvent();
    public static UnityEvent OnWasteAmmo = new UnityEvent();
    public static UnityEvent OnWasteHealth = new UnityEvent();

}
