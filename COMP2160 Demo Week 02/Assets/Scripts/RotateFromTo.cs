using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFromTo : MonoBehaviour
{
    [SerializeField] private Vector3 fromAxis = Vector3.up;
    [SerializeField] private Vector3 toAxis = Vector3.up;

    void Update()
    {
        transform.rotation = Quaternion.FromToRotation(fromAxis, toAxis);
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + fromAxis.normalized * 100f);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + toAxis.normalized * 100f);
    }
}
