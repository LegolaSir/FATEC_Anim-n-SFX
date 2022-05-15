using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftingPrisonBars : MonoBehaviour
{
    [SerializeField] private Animator controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            controller.SetTrigger("btn_prison");
        }
    }
}
