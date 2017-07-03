using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public Transform origin;
    Vector3 offset;
    public float speed;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - origin.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = origin.position + offset;
    }
}
