using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAngleAxis : MonoBehaviour
{
    [SerializeField] private Vector3 axis = Vector3.up;
    [SerializeField] private float angle;

    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(angle, axis);
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + axis.normalized * 100f);
    }
}
