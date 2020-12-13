using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Rigidbody.velocity.y / 10, Input.GetAxis("Vertical"));
        Rigidbody.velocity = input * 500 * Time.fixedDeltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        HealthManager apple = other.GetComponentInChildren<HealthManager>();
        if (apple != null)
        {
            GameManager.Instance.interactWith = other.gameObject.name;
            EventManager.WhatToInteract.Invoke();
        }

        AmmoManager ammo = other.GetComponentInChildren<AmmoManager>();
        if (ammo != null)
        {
            GameManager.Instance.interactWith = other.gameObject.name;
            EventManager.WhatToInteract.Invoke();
        }

        DoorController door = other.GetComponentInChildren<DoorController>();
        if (door != null)
        {
            GameManager.Instance.interactWith = other.gameObject.name;
            EventManager.WhatToInteract.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager.Instance.interactWith = "nothing";
        EventManager.WhatToInteract.Invoke();
    }
}
