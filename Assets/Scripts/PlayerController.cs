using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerMovement = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            //Move up negative in x
            playerMovement.x += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerMovement.x -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerMovement.z -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerMovement.z += speed;
        }

        transform.position = playerMovement;
    }
}
