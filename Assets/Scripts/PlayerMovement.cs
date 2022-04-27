using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int speed = 5;

    private void FixedUpdate()
    {
        this.transform.Translate(Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed, 0, 0);
    }
}
