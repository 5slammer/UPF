﻿using System;
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
        float x_pos = (float)Math.Truncate(player.transform.position.x + 0.5f + Input.GetAxis("Horizontal"));
        float y_pos = (float)Math.Truncate(player.transform.position.y - 0.5f + Input.GetAxis("Vertical"));
        transform.position = new Vector3(x_pos, y_pos, 0);
    }
}
