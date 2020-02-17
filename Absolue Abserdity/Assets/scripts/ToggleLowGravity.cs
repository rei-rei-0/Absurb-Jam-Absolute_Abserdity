using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLowGravity : MonoBehaviour
{
    [SerializeField]
    private float lowerGravityCoefficient;
    private bool lowerGravOn;

    
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -9.8F, 0);
        lowerGravOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(lowerGravOn == false)
            {
                Physics.gravity = new Vector3(0, (-9.8F * lowerGravityCoefficient), 0);
                lowerGravOn = true;
            }
            else
            {
                Physics.gravity = new Vector3(0, -9.8F, 0);
                lowerGravOn = false;
            }
        }
    }
}
