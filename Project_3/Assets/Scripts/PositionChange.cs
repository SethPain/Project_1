using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChange : MonoBehaviour {

    private bool keepGoing = true;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 150 && keepGoing)
        {
            transform.position += Vector3.left * .02f;
        } else if (transform.position.x == 150 && keepGoing)
        {
            keepGoing = false;
        } else if (transform.position.x < 166)
        {
            transform.position += Vector3.right * .02f;
        } else if (transform.position.x == 166)
        {
            keepGoing = true;
        }
    }
}
