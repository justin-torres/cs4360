using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(tankControl))]
[RequireComponent(typeof(Rigidbody))]
public class tankInput : MonoBehaviour
{

    private float forwardInput;
    public float ForwardInput
    {
        get { return forwardInput; }
    }

    private float rotationInput;
    public float RotationInput
    {
        get { return rotationInput; }
    }

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        rotationInput = Input.GetAxis("Horizontal");
    }
}
