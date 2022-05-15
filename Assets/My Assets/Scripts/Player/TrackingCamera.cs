using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingCamera : MonoBehaviour
{
    [Header("Player GameObject")]
    [SerializeField] private Transform target;
    [SerializeField] private Transform cameraPos;

    private Vector3 offset;

    private void Start()
    {
        CalculateOffset();
    }

    private void LateUpdate()
    {
        //transform.position = cameraPos.position;
        transform.position = target.position + offset;
    }

    public void CalculateOffset()
    {
        offset = this.transform.position - target.position;
    }
}
