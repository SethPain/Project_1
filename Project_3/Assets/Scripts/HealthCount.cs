using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour {

    public int healthTotal = 100;
    public Text countText;

	// Use this for initialization
	void Start () {
        countText.text = "Health: " + healthTotal.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Fruit")) {
            healthTotal += 10;
            countText.text = "Health: " + healthTotal.ToString();
        }
    }
}
