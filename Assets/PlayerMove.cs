using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rig;
    public int vor;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            rig.AddForce(transform.up * vor);
        }
        if (Input.GetKey("s"))
        {
            rig.AddForce(transform.up * -vor);
        }
        if (Input.GetKey("a"))
        {
            rig.AddForce(transform.right * -vor);
        }
        if (Input.GetKey("d"))
        {
            rig.AddForce(transform.right * vor);
        }
    }

    
}
