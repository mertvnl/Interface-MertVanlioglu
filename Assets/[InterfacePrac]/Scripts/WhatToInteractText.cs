using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhatToInteractText : Singleton<WhatToInteractText>
{
    private Text whatToInteract;
    public Text WhatToInteract { get { return (whatToInteract == null) ? whatToInteract = GetComponent<Text>() : whatToInteract; } }

    private void Start()
    {
        WhatToInteract.text = "You can interact with : Nothing"; 
    }

    public void UpdateText(string objectName)
    {
        WhatToInteract.text = "You can interact with : " + objectName;
    }
}
