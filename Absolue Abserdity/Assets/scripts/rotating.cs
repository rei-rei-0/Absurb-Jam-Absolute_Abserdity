﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * 0,0, 1));
        //rotation happens z axis
        //i think time delta time is ingame seconds
    }
}
