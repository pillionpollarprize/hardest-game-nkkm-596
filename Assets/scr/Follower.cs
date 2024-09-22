using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform target;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate enemy to look at player
        transform.LookAt(target);

        // Vector3.forward vs transform.forward
        // Vector3.forward represent world space forward direction, like north, west, east, south
        // transform.forward represent local space forward direction, like right, left, up, down
        transform.position += transform.forward * speed * Time.deltaTime;

    }
}
