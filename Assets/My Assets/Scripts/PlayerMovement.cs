using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Speed Entry")]
    [SerializeField] private float speed = 5;

    private float tmp;

    /* Unity Methods */
    private void Start()
    {
        tmp = Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        Movement();
    }

    /* Custom Methods */
    public void Movement()
    {
        float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(vInput, 0, -hInput);

        transform.Translate(speed * tmp * direction);
    }
}
