using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3((float)Math.Truncate(player.transform.position.x+0.5f), (float)Math.Truncate(player.transform.position.y-0.5f), 0);
    }
}
