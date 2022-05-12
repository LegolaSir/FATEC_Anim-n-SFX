using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingCamera : MonoBehaviour
{
    [Header("Player GameObject")]
    [SerializeField] private Transform target;

    private Vector3 offset;

    private void Start()
    {
        CalculateOffset();
    }

    private void Update()
    {
        transform.position = target.position + offset;
    }

    public void CalculateOffset()
    {
        offset = this.transform.position - target.position;
    }
}
