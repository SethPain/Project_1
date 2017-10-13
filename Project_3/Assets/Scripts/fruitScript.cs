using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitScript : MonoBehaviour {

    AudioSource sound;

	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		transform.localEulerAngles += new Vector3 (0, 5.0f, 0);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Player")) {
            sound.Play();
            Destroy (gameObject, .25f);
            
		}
	}
}
