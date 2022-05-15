using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingWalls : MonoBehaviour
{
    [SerializeField] private Animator controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            controller.SetBool("IsNear", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            controller.SetBool("IsNear", false);
        }
    }
}
