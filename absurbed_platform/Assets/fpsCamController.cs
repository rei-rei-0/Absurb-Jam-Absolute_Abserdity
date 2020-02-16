using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCamController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private float rota;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - player.transform.position;
        rota = player.transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        rota = player.transform.rotation.y;
        transform.Rotate(0f, rota, 0f, Space.Self);
    }
}
