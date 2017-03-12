using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {

    public GameObject player;
    private float x_stick,y_stick,h,v,x_pos,y_pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if (h != 0 || v != 0){
            x_pos = (float)Math.Truncate(player.transform.position.x + 0.5f + h);
            y_pos = (float)Math.Truncate(player.transform.position.y - 0.5f + v);
            transform.position = new Vector3(x_pos, y_pos, 0);
        }

        if (Input.GetKeyDown(KeyCode.E)){
            GameObject tile = GameObject.Find(transform.position.x.ToString() + transform.position.y.ToString());
            tile.SendMessage("use", "hoe");
        }
    }
}
