using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody body;
    //private GameObject ball;
    public float speed = 5;
    public float jumpPower = 10;

    public Vector3 facing;
    public Vector3 perpendicular;

    void Start()
    {
        //ball = GameObject.FindGameObjectWithTag("Player");
        body = GetComponent<Rigidbody>();

        facing = transform.forward;
        perpendicular = GetPerpendicular(facing);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 movement = body.velocity;
        movement += ((facing*zInput) + (perpendicular*xInput))*speed;
        if(movement.magnitude > 0)
            movement = Vector3.ClampMagnitude(movement,speed);
        else
            movement = Vector3.ClampMagnitude(movement,-speed);

        print(movement);
       /*   
        Vector3 movement = new Vector3(xInput, 0, zInput);
        movement*=speed;
        movement = Vector3.ClampMagnitude(movement,speed);
         
         */
        body.AddForce(movement);
        body.velocity = Vector3.ClampMagnitude(body.velocity,speed);
        if(Input.GetButtonDown("Jump"))
        {
            body.AddForce(Vector3.up*jumpPower,ForceMode.Impulse);
        }        

        if(body.velocity.magnitude!=0)
        {
            facing.x = body.velocity.x;
            facing.z = body.velocity.z;
            perpendicular = GetPerpendicular(facing);
        }
    }

    void FixedUpdate_base()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xInput, 0, zInput);
        movement*=speed;
        movement = Vector3.ClampMagnitude(movement,speed);
        body.AddForce(movement);
      
        if(Input.GetButtonDown("Jump"))
        {
            body.AddForce(Vector3.up*jumpPower,ForceMode.Impulse);
        }

        
    }

    
    private Vector3 GetPerpendicular(Vector3 inVec)
    {
        return new Vector3(inVec.z, 0, -inVec.x);
    }
}
