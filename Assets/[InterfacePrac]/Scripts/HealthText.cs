using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public bool canInteract = false;
    private int healthPoints = 1;
    private Text healtTextUI;
    public Text HealthTextUI { get { return (healtTextUI == null) ? healtTextUI = GetComponent<Text>() : healtTextUI; } }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && FindObjectOfType<PlayerController>().currentInteraction == PlayerController.WhatToInteract.Apple)
        {
            Use();
        }
    }

    public void Use()
    {
        healthPoints += 5;
        Debug.Log("You earned 5 health points");
        Waste();
        UpdateText();
    }

    public void Waste()
    {
        healthPoints -= 2;
        Debug.Log("You wasted 2 health points");
    }

    void Start()
    {
        UpdateText();
    }


    private void UpdateText()
    {
        HealthTextUI.text = "Health : " + healthPoints;
    }

}
