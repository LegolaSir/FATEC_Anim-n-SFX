using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggering : MonoBehaviour
{
    /* Attributes */
    private Animator anim;

    /* Unity Methods */
    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            anim.SetBool("IsNear", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("IsNear", false);
        }
    }
}
