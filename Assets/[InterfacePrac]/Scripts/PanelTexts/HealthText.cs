using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    private Text healtTextUI;
    public Text HealthTextUI { get { return (healtTextUI == null) ? healtTextUI = GetComponent<Text>() : healtTextUI; } }
    void Start()
    {
        UpdateText();
    }
    private void OnEnable()
    {
        EventManager.OnAppleInteraction.AddListener(UpdateText);
        EventManager.OnWasteHealth.AddListener(WasteHealth);
    }
    private void OnDisable()
    {
        EventManager.OnAppleInteraction.RemoveListener(UpdateText);
        EventManager.OnWasteHealth.RemoveListener(WasteHealth);
    }
    private void UpdateText()
    {
        HealthTextUI.text = "Health : " + HealthManager.Instance.health;
    }
    private void WasteHealth()
    {
        HealthManager.Instance.health--;
        HealthTextUI.text = "Health : " + HealthManager.Instance.health;
        Debug.Log("You have wasted your health points.");
    }


}
