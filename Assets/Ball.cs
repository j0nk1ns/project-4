using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;
    public float Thrust = 200f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        if(collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("here");
            rb.AddForce(Vector3.up * Thrust);
        }
    }


}

