using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour {
    public GameObject dirt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void use(string tool)
    {
        if (tool == "hoe")
        {
            GameObject instaniatedObject = Instantiate(dirt, transform.position, transform.rotation);
            instaniatedObject.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            instaniatedObject.name = transform.position.x.ToString() + transform.position.y.ToString();
            Destroy(gameObject);
        }
    }
}
