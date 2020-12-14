using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour, I_Interactable
{
    public void Use()
    {
        HealthText.Instance.healthPoints += 5;
        Debug.Log("You earned 5 health points");
        Waste();
        UpdateText();
    }

    public void Waste()
    {
        HealthText.Instance.healthPoints -= 2;
        Debug.Log("You wasted 2 health points");
    }

    private void UpdateText()
    {
        HealthText.Instance.HealthTextUI.text = "Health : " + HealthText.Instance.healthPoints;
    }
}
