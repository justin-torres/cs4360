using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(tankInput))]
[RequireComponent(typeof(Rigidbody))]
public class tankControl : MonoBehaviour
{
    private tankInput input;
    private Rigidbody rb;
    public float tankSpeed = 15f;
    public float tankRotationSpeed = 15f;

    void Start()
    {
        input = GetComponent<tankInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb && input)
        {
            tankMovement();
        }
    }

    protected void tankMovement()
    {   
        Vector3 wantedPosition = transform.position + transform.forward * input.ForwardInput * tankSpeed * Time.deltaTime;
        rb.MovePosition(wantedPosition);
    }
}
