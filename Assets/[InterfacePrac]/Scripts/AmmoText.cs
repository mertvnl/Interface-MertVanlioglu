using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : Singleton<AmmoText>
{
    public int ammoAmount = 0;
    private Text ammoTextUI;
    public Text AmmoTextUI { get { return (ammoTextUI == null) ? ammoTextUI = GetComponent<Text>() : ammoTextUI; } }

    void Start()
    {
        AmmoTextUI.text = "Ammo : " + ammoAmount;
    }
}
