using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 0f;  // m/s
    [SerializeField] private float rotationSpeed = 60; // deg/s
    [SerializeField] private Vector3 rotationAxis = Vector3.up; // world frame


    void Update()
    {
        // move the ship forwards
        Vector3 move = speed * Vector3.forward * Time.deltaTime;
        // transform.Translate(move, Space.Self);        
        transform.localPosition = transform.localPosition + move;

        float angle = rotationSpeed * Time.deltaTime;
        Quaternion q = Quaternion.AngleAxis(angle, rotationAxis);

        // transform.Rotate(rotationAxis, angle);
        transform.localRotation = q * transform.localRotation;
    }
}
