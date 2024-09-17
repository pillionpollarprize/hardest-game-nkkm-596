using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float speed = 5.0f;
    public float height = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //y is now a sine wave (moves up and down)
        var y = Mathf.Sin(Time.time * speed) * height; 

        // x and z remain the same
        var x = transform.position.x;
        var z = transform.position.z;

        if (y < 0) y = -y; 
        transform.position = new Vector3(x, y, z);

    }
}
