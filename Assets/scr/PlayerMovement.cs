using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15.0f;
    Vector3 startPos;
    private void StartGame()
    {
        startPos = new Vector3(0, 1, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    // speed * Time.deltaTime - to make the movement frame rate independent
        //    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(-(speed * Time.deltaTime), 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(0, 0, -(speed * Time.deltaTime));
        //}

        //var - select the type of variable
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        // normalized - move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("Game Over");
            transform.position = startPos;
        }
    }
}
