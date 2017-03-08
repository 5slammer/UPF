using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }
}