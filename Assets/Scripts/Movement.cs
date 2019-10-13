using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 500f;

   
    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime);
        }
    }
}
