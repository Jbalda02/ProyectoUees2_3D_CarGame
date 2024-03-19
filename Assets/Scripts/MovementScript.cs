using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{ 
    private CharacterController _controller;
    public float speed = 12f;
    public float gravity = 9.81f * 2;
    public float rotationSpeed;
    Vector3 velocity;
    bool isMoving;
    Vector3 lastPosition = new Vector3(0f, 0f, 0f);
    private Rigidbody rb;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
  
    //Get Inputs
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    
    //Move Calc

    Vector3 move = transform.right * x + transform.forward * z;
    _controller.Move(move * speed * Time.deltaTime);
    //Move App
    transform.Rotate(Vector3.up * x * rotationSpeed * Time.deltaTime);

    


    //Constant Gravity
    velocity.y += gravity * Time.deltaTime;
    _controller.Move(velocity * Time.deltaTime);
    //Move Check
    if (lastPosition != gameObject.transform.position)
    {
        isMoving = true;
    }
    else
    {
        isMoving = false;
    }
    }
    
}

