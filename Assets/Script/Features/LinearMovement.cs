using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    public float speed = 0;

    public Vector3 direction = Vector3.zero;
    
    void Update()
    {
        transform.position += speed * direction * Time.deltaTime;
    }
}
