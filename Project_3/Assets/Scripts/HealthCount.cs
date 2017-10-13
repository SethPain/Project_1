using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour {

    public int healthTotal = 100;
    public Text countText;
    public bool isInvulnerable = false;
    public float timer;


	// Use this for initialization
	void Start () {
        countText.text = "Health: " + healthTotal.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        // Debug.Log(timer);
        if (timer <= 0) {
            isInvulnerable = false;
        }
        countText.text = "Health: " + healthTotal.ToString();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Fruit"))
        {
            healthTotal += 10;
            // countText.text = "Health: " + healthTotal.ToString();
        }
        else if (other.gameObject.CompareTag("Fruit_2"))
        {
            healthTotal += 20;
        } 
        else if (other.gameObject.CompareTag("Mega"))
        {
            healthTotal += 50;
            // countText.text = "Health: " + healthTotal.ToString();
            isInvulnerable = true;
            timer = 30.0f;
        }
        else if (other.gameObject.CompareTag("Junk") & !isInvulnerable)
        {
            healthTotal -= 10;
            // countText.text = "Health: " + healthTotal.ToString();
        }
        else if (other.gameObject.CompareTag("Junk_2") & !isInvulnerable)
        {
            healthTotal -= 20;
            // countText.text = "Health: " + healthTotal.ToString();
        }
    }
}
