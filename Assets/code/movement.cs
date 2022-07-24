using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{


    public CharacterController controller;

    //movement speed
    public float speed = 12f;

   

    Vector3 velocity;


    //camara rotation speed
    public float turnSpeed = 50f;
    void Update()
    {
        //camara rotation
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        //movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);

      
    }
   
}