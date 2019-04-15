using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 up = new Vector3(0, 500, 0);
    public Vector3 left = new Vector3(-50, 0, 0);
    public Vector3 right = new Vector3(50, 0, 0);
    public Vector3 forward = new Vector3(0, 0, 50);
    public Vector3 backward = new Vector3(0, 0, -50);

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(up);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(right);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(forward);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(backward);
        }
    }

}