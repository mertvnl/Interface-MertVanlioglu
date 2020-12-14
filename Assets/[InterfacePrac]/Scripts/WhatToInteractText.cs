using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhatToInteractText : MonoBehaviour
{
    private Text whatToInteract;
    public string interactWith = "Nothing";
    public Text WhatToInteract { get { return (whatToInteract == null) ? whatToInteract = GetComponent<Text>() : whatToInteract; } }

    private void Start()
    {
        WhatToInteract.text = "You can interact with : " + interactWith; 
    }

    public void UpdateText()
    {
        WhatToInteract.text = "You can interact with : " + interactWith;
    }
}
