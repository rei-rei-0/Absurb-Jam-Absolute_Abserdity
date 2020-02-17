using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    public Text TimerText; //remember to drag the Text component down next to Timer Text; REFERENCING
    public bool playing; //check the playing check box under the script
    private float Timer;
 
    
    void Update()
    {
        
        if (playing == true)
        {
            

            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
          
        }

    }

}//okay so this working now
