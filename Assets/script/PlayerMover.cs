using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    public int score = 0;
    public float velocity = 2;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * velocity);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * velocity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * velocity);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * velocity);
        }
    }
}
