using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotate : MonoBehaviour
{
    //referred the rotating script and named it rotation
    //need to also apply it in the inspection tab
    public rotating rotation;

    //void Update()
   // {
        //when object collides with something, the collision information is captured
        void OnCollisionEnter(Collision collisionInfo)
        {
            //we can change the tag to bullet or the tag of obj hitting to pause
            if (collisionInfo.collider.tag == "bullet")
            {
                rotation.enabled = !rotation.enabled;
                Debug.Log ("FIANLLY");
                //if (rotation.enabled = true)
                // {
                //rotation.enabled = false;
                // }
                // if (rotation.enabled = false)
                // {
                //rotation.enabled = true;
                // }

                //unactives the rotating script
                //transform.position = new Vector3(0, 6, 0);
                //transform.Rotate = new Vector3(0, 0, 0);

            }
        }
        /*void OnCollisionExit(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Player")
            {
                rotation.enabled = true;
            }
            */
    //}//this doesnt work, doesnt stop the thing
 }

