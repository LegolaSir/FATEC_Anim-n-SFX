using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStone : MonoBehaviour
{
    [Header("Stone Animator Component")]
    [SerializeField] private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            anim.SetTrigger("RUN");

        }
    }
}
