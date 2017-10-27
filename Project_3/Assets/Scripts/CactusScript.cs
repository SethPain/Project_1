using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScript : MonoBehaviour {

    AudioSource sound; 

	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
            Destroy(gameObject, 0);
        if (other.gameObject.CompareTag("Player"))
            sound.Play();
    }
}
