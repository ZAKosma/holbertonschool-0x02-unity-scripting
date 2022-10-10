using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerMovement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            //Move up negative in x
            playerMovement.z += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerMovement.z -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerMovement.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerMovement.x += speed;
        }

        rb.AddForce(playerMovement);
    }
}
