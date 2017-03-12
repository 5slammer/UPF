using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{

    public float speed;            //Floating point variable to store the player's movement speed.
    public string direction;

    void Start()
    {
        direction = "N";
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void Update()
    {
        direction = get_direction();
    }

    private string get_direction()
    {
        string dir = "";
        if (Input.GetAxis("Vertical") == 1){
            dir += "N";
        }else if (Input.GetAxis("Vertical") == -1){
            dir += "S";
        }
        if (Input.GetAxis("Horizontal") == 1){
            dir += "E";
        }
        else if (Input.GetAxis("Horizontal") == -1){
            dir += "W";
        }
        return dir;
    }
}