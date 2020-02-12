using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBackStart : MonoBehaviour
{
    public GameObject RollerBall;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

    }
    /*public Animator UpDownAnima;
        void OnCollisionEnter(Collision collisionInfo)
        {
            //we can change the tag to bullet or the tag of obj hitting to pause
            if (collisionInfo.collider.tag == "Player")
            {
                void Stop("UpDownAnima");

            }
        }IGNORE THIS WHOLE DOCU PLEASE
   */
}
