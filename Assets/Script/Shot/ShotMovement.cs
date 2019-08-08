using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShotMovement : MonoBehaviour
{
    [SerializeField]
    private float force = 0f;
    [SerializeField]
    public Vector2 direction = Vector2.zero;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(direction * force);
    }
}
