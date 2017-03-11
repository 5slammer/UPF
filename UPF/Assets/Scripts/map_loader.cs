using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_loader : MonoBehaviour {
    private int[,] map;
    public GameObject grass,water,dirt,rock;
	// Use this for initialization
	void Start () {
        map = new int[20, 20] { { 2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,3,3,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,0,2,2,2,2,3,3,3,2,2},
                                { 2,1,1,1,1,1,1,1,1,1,0,3,3,3,3,3,3,3,3,2},
                                { 2,1,1,1,1,1,1,1,1,1,0,0,3,3,3,3,3,3,3,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,3,3,3,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2},
                                { 2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
                              };
        load_map();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void load_map () {
        int row = 0;
        int col = 0;
        foreach (int tileType in map) {
            row += 1;
            GameObject tile = dirt; //0
            if (tileType == 1) {
                tile = grass;
            }else if (tileType == 2){
                tile = rock;
            }else if (tileType == 3){
                tile = water;
            }
            GameObject instaniatedObject = Instantiate(tile, transform.position, transform.rotation);
            instaniatedObject.transform.SetParent(gameObject.transform);
            instaniatedObject.transform.position = new Vector3(row, col, 0);
            if (row == 20) {
                row = 0;
                col -= 1;
            }
        }
        transform.position = new Vector3(0, 0, 0);
    }
}
