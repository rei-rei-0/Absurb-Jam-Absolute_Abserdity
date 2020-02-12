using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DONT USE STILL TESTING, NOT WORKING :(
//this is a test to rotate the object but stop it when object collides with it 
public class rotatingv2 : MonoBehaviour
{
    private Vector3 startPos;
   // public GameObject book3;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(Time.deltaTime * 0, 0, 1));
        //rotation happens z axis

        void OnCollisionEnter (Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Player")
            {
                transform.position = startPos;
                //stops the object movement
                /*book3.Rigidbody.velocity = Vector3.zero;
                book3.Rigidbody.angularVelocity = Vector3.zero; i cant make it work */

            }
        }
    }
}
