using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update

    public int jumpSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        Vector3 velocity = new Vector3(0, body.velocity.y, 0);
        if (Input.GetKeyDown("space"))
        {
            velocity.y = jumpSpeed;
        }
        body.velocity = velocity;
    }
}
