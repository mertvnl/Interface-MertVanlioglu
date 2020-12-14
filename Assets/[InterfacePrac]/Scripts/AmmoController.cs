using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour, I_Interactable
{
    public void Use()
    {
        AmmoText.Instance.ammoAmount += 2;
        Debug.Log("You earned +2 ammo");
        Waste();
        UpdateText();
    }

    public void Waste()
    {
        AmmoText.Instance.ammoAmount--;
        Debug.Log("You wasted 1 ammo");
    }

    private void UpdateText()
    {
        AmmoText.Instance.AmmoTextUI.text = "Ammo : " + AmmoText.Instance.ammoAmount;
    }
}
