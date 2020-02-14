using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEndUI : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject Timer;
    //ScriptName SNTimer = GameObject.getComponent<

    // Start is called before the first frame update
    void Start()
    {
        //the endgame text deactives
        uiObject.SetActive(false);
        //Timer.GetComponent<UITimer>().stop = true;

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            //when the player hits the object, the endgame will appear
            uiObject.SetActive(true);
            Timer.GetComponent<UITimer>().playing = false;//grabs the boolean from the UITimer script
            //timer stops
            //referencing has to be public not private



        }
    }
}
