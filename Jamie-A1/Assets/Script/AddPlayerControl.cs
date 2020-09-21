using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControl : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Velocity;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyPositive))
        GetComponent<Rigidbody>().velocity += v3Velocity;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Velocity;
    }
}
