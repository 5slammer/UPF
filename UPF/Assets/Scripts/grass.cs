using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour {
    public Sprite dirt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void use(string tool) {
        if (tool == "hoe"){
            GetComponent<SpriteRenderer>().sprite = dirt;
        }
    }
}
