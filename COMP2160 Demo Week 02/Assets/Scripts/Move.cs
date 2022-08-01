using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 3.1f;

    void Update()
    {
        // move the ship forwards
        Vector3 move = speed * Vector3.forward * Time.deltaTime;
        transform.Translate(move, Space.Self);        
    }
}
