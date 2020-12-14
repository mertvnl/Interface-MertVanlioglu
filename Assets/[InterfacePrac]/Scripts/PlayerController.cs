using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject nearestGameObject = null;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Rigidbody.velocity.y / 10, Input.GetAxis("Vertical"));
        Rigidbody.velocity = input * 500 * Time.fixedDeltaTime;
    }
    private void Update()
    {
        if (nearestGameObject == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            I_Interactable i_interactable = nearestGameObject.GetComponentInChildren<I_Interactable>();
            if (i_interactable != null)
            {
                i_interactable.Use();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        nearestGameObject = other.gameObject;
        WhatToInteractText.Instance.UpdateText(other.gameObject.name);
    }
}
