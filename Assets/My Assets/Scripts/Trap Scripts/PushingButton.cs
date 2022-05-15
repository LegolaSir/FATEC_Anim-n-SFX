using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingButton : MonoBehaviour
{
    [SerializeField] private Rigidbody stone;

    private Animator controller;

    private void Start()
    {
        controller = this.GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && this.gameObject.name == "BTN_Rock")
        {
            controller.SetTrigger("btn_push");
            stone.useGravity = true;
        }
    }
}
