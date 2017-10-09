﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddForce_Door : MonoBehaviour {

    public float thrust;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb.GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, thrust, ForceMode.Impulse); 
    }
}
