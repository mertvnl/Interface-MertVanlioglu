using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour, IUsable, IWastable
{
    private int ammoAmount = 0;
    private Text ammoTextUI;
    public Text AmmoTextUI { get { return (ammoTextUI == null) ? ammoTextUI = GetComponent<Text>() : ammoTextUI; } }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && FindObjectOfType<PlayerController>().currentInteraction == PlayerController.WhatToInteract.Ammo)
        {
            Use();
        }
    }

    public void Use()
    {
        ammoAmount += 2;
        Debug.Log("You earned +2 ammo");
        Waste();
        UpdateText();
    }

    public void Waste()
    {
        ammoAmount--;
        Debug.Log("You wasted 1 ammo");
    }

    void Start()
    {
        UpdateText();
    }

    
    private void UpdateText()
    {
        AmmoTextUI.text = "Ammo : " + ammoAmount;
    }
}
