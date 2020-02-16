using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnima : MonoBehaviour
{
    //refer to Animator in here and inspector
    public Animator Anima;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "bullet")
        {
            //disables the animator
            Anima.enabled = !Anima.enabled;//turns animator and and off :D
            Debug.Log("animation stop");//this is a test
        }
    }
}
