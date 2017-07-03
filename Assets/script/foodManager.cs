using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodManager : MonoBehaviour {

    Vector3 vr;
    public PlayerMover pm;

	// Use this for initialization
	void Start () {
        vr = new Vector3(15, 30, 45);
        pm = FindObjectOfType<PlayerMover>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(vr*Time.deltaTime);
	}
    void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        pm.score += 1;
        Debug.Log("collision");
    }
}
