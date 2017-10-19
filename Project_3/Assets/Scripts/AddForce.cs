using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    public Rigidbody rb;
    public int speed = 25;

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        // GetComponent<Rigidbody>().AddForce(-transform.right * 500);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = gameObject.transform.position - mousePos;
        GetComponent<Rigidbody>().AddForce(dir.normalized * speed, ForceMode.Impulse);
        GetComponent<Rigidbody>().useGravity = true;
    }

    
}
