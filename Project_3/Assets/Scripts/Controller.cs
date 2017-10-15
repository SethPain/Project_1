using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float inputDelay = 0.1f;
    public float forwardVel = 12;
    public float rotateVel = 100;

    Quaternion targetRotation;
    Rigidbody rBody;

    float forwardInput, rotateInput;

    public Quaternion TargetRotation
    {
        get { return targetRotation; }
    }

    // Use this for initialization
    void Start()
    {
        targetRotation = transform.rotation;
        rBody = GetComponent<Rigidbody>();

        forwardInput = rotateInput = 0;
    }

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        rotateInput = Input.GetAxis("Horizontal");

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Turn();
    }

    void FixedUpdate()
    {
        Run();
    }

    void Run()
    {
        if (Mathf.Abs(forwardInput) > inputDelay)
        {
            // move 
            rBody.velocity = transform.forward * forwardInput * forwardVel;
        }
        else
        {
            // zero velocity
            rBody.velocity = Vector3.zero;
        }
    }

    void Turn()
    {
        if (Mathf.Abs(rotateInput) > inputDelay)
        {
            targetRotation *= Quaternion.AngleAxis(rotateVel * rotateInput * Time.deltaTime, Vector3.up);
        } else
            transform.rotation = targetRotation;
    }
}
