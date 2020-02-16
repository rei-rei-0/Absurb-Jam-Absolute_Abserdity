using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeCam : MonoBehaviour
{
    /*[SerializeField]
    private GameObject thirdPersonCam;
    private bool thirdCamOn;
    [SerializeField]
    private GameObject firstPersonCam;
    private bool firstCamOn = false;
    [SerializeField]
    private GameObject player;    
 
    // Start is called before the first frame update
    void Start()
    {
        //initialize the 3rd person camera to be the default camera
        thirdPersonCam.GetComponent<Camera>().enabled = true;
        thirdCamOn = true;  //flag included to aid in case-testing

        //do not have the secondary 1st person camera enabled
        firstPersonCam.GetComponent<Camera>().enabled = false;
        firstCamOn = false;  //flag included to aid in case-testing
    }

    // Update is called once per frame
    void Update()
    {
        //if the toggle camera key (Q) is pressed
        if(Input.GetKey(KeyCode.Q))
        {
            //switch to the currently disabled camera and turn off the camera in use
            //depends on current camera
            if(thirdCamOn)
            {
                firstPersonCam.GetComponent<Camera>().enabled = true;
                firstCamOn = true;
                thirdPersonCam.GetComponent<Camera>().enabled = false;
                thirdCamOn = false;
            }
            else
            {
                thirdPersonCam.GetComponent<Camera>().enabled = true;
                thirdCamOn = true;
                firstPersonCam.GetComponent<Camera>().enabled = false;
                firstCamOn = false;
            }
        }

        //freeze movement when in first person
        if(firstCamOn)
        {
            player.GetComponent<Player_Exp>().enabled = false;
            player.GetComponent<Player>().enabled = false;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        else
        {
            player.GetComponent<Player_Exp>().enabled = true;
            player.GetComponent<Player>().enabled = true;
        }
    }*/
    /*[SerializeField]
    private GameObject thirdPersonCam;
    [SerializeField]
    private GameObject firstPersonCam;
 
    void Start()
    {
        thirdPersonCam.GetComponent<Camera>().enabled = true;
        firstPersonCam.GetComponent<Camera>().enabled = false;
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            thirdPersonCam.GetComponent<Camera>().enabled = !thirdPersonCam.GetComponent<Camera>().enabled;
            firstPersonCam.GetComponent<Camera>().enabled = !firstPersonCam.GetComponent<Camera>().enabled;
        }
    }*/

    public GameObject thirdPersonCam;
    public GameObject firstPersonCam;
    public GameObject player;
    public int camMode;
    public Vector3 pos;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //pos = player.transform.position;
    }
    void Update()
    {
        //transform.LookAt(new Vector3(player.transform.position.x, player.transform.position.y+2, player.transform.position.z));
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(camMode == 0) {camMode = 1;}
            else {camMode = 0;}
            StartCoroutine(CamChange());
            //pos = player.transform.position;
            //firstPersonCam.transform.position = pos;
        }
    }

    IEnumerator CamChange()
    {
        yield return new WaitForFixedUpdate();
        if(camMode == 1)
        {
            thirdPersonCam.SetActive(true);
            firstPersonCam.SetActive(false);
            //player.GetComponent<Player_Exp>().enabled = true;
            //player.GetComponent<Player>().enabled = true;
        }
        if(camMode == 0)
        {
            thirdPersonCam.SetActive(false);
            firstPersonCam.SetActive(true);
            //player.GetComponent<Player_Exp>().enabled = false;
            //player.GetComponent<Player>().enabled = false;
            //player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //Vector3 stayPut = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
            //firstPersonCam.transform.LookAt(stayPut);
        }
    }
}
