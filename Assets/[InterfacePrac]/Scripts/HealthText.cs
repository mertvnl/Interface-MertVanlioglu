using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : Singleton<HealthText>
{
    public int healthPoints = 1;
    private Text healtTextUI;
    public Text HealthTextUI { get { return (healtTextUI == null) ? healtTextUI = GetComponent<Text>() : healtTextUI; } }

    void Start()
    {
        HealthTextUI.text = "Health : " + healthPoints;
    }
}
