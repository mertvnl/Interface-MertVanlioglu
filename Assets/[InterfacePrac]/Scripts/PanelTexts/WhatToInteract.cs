using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhatToInteract : MonoBehaviour
{
    private Text interactWith;
    public Text InteractWith { get { return (interactWith == null) ? interactWith = GetComponent<Text>() : interactWith; } }
    void Start()
    {
        InteractWith.text = "You can interact with : nothing";
    }

    private void OnEnable()
    {
        EventManager.WhatToInteract.AddListener(UpdateText);
    }
    private void OnDisable()
    {
        EventManager.WhatToInteract.RemoveListener(UpdateText);
    }

    public void UpdateText()
    {
        InteractWith.text = "You can interact with : " + GameManager.Instance.interactWith;
    }
}
