using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    private Text ammoTextUI;
    public Text AmmoTextUI { get { return (ammoTextUI == null) ? ammoTextUI = GetComponent<Text>() : ammoTextUI; } }
    void Start()
    {
        UpdateText();
    }

    private void OnEnable()
    {
        EventManager.OnAmmoInteraction.AddListener(UpdateText);
        EventManager.OnWasteAmmo.AddListener(WasteAmmo);
    }
    private void OnDisable()
    {
        EventManager.OnAmmoInteraction.RemoveListener(UpdateText);
        EventManager.OnWasteAmmo.RemoveListener(WasteAmmo);
    }

    private void WasteAmmo()
    {
        AmmoManager.Instance.ammo--;
        AmmoTextUI.text = "Ammo : " + AmmoManager.Instance.ammo;
        Debug.Log("You have wasted your ammo");
    }

    private void UpdateText()
    {
        AmmoTextUI.text = "Ammo : " + AmmoManager.Instance.ammo;
    }
}
